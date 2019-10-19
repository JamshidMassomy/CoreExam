using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain.DBContext;

namespace XM.Application.QuestionType.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommandHandler : IRequestHandler<CreateQuestionTypeCommand, object>
    {
        private readonly EMSContext eMSContext;
        public CreateQuestionTypeCommandHandler(EMSContext eMSContext)
        {
            this.eMSContext = eMSContext;
        }
        public async Task<object> Handle(CreateQuestionTypeCommand request, CancellationToken cancellationToken)
        {
            var questionType = new Models.Entity.QuestionType
            {
                Name = request.Name
            };

            await eMSContext.AddAsync(questionType);
            await eMSContext.SaveChangesAsync(cancellationToken);
            return new
            {
                Message = "New Question Type added."
            };
        }
    }
}
