using Domain.DBContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Question.Commands.CreateQuestion
{
    public class CreateQuestion: IRequest<object>
    {
        public int QuestionTypeID { get; set; }
        public int CategoryID { get; set; }
        public string Lebel { get; set; }
        public int Point { get; set; }
        public bool isActive { get; set; }
    }
    public class CreateQuestionHandler : IRequestHandler<CreateQuestion, object>
    {
        private readonly EMSContext EMSContext;
        public CreateQuestionHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }

        public async Task<object> Handle(CreateQuestion request, CancellationToken cancellationToken)
        {
            var Question = new Models.Entity.Question
            {
                CategoryId = request.CategoryID,
                QuestionTypeId = request.QuestionTypeID,
                Lebel = request.Lebel,
                Point = request.Point,
                IsActive = request.isActive
            };
            await EMSContext.AddAsync(Question);
            await EMSContext.SaveChangesAsync(cancellationToken);

            return new
            {
                Message = "New Question Type added."
            };
        }
    }
}
