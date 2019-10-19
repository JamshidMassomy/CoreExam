using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.DBContext;

namespace XM.Application.Question.Queries.GetQuestions.GetQuestionList
{
    public class GetQuestionQueryHandler
    {
        private readonly EMSContext eMSContext;
        public GetQuestionQueryHandler(EMSContext _eMSContext)
        {
            this.eMSContext = _eMSContext;
        }

        public async Task<object> Handler(GetQuestionQuery request, CancellationToken cancellationToken)
        {
            var questions  = await eMSContext.Question
                .Select(x => new
                {
                    ID = x.Id,
                    Lebel = x.Lebel,
                    Point = x.Point,
                    IsActive= x.IsActive,
                    QuestionTypeID = x.QuestionTypeId
                }).ToListAsync();

            return questions;
        }
    }
}
