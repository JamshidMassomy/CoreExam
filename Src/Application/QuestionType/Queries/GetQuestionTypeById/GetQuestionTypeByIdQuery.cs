using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.DBContext;

namespace XM.Application.QuestionType.Queries.GetQuestionTypeById
{
    public class GetQuestionTypeByIdQuery:IRequest<object>
    {
        public int Id { get; set; }
    }
    public class GetQuestionTypeByIdQueryHandler : IRequestHandler<GetQuestionTypeByIdQuery, object>
    {
        private readonly EMSContext eMSContext;
        public GetQuestionTypeByIdQueryHandler(EMSContext eMSContext)
        {
            this.eMSContext = eMSContext;
        }
        public async Task<object> Handle(GetQuestionTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var questionType = await eMSContext.QuestionType
                .Where(x => x.Id == request.Id)
                .Select(x => new
                    {
                        ID = x.Id,
                        Name = x.Name
                    }
                ).FirstOrDefaultAsync();

            return questionType;
        }
    }
}
