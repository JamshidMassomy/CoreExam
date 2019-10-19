using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.DBContext;

namespace XM.Application.QuestionType.Queries.GetQuestionTypesList
{
    public class GetQuestionsTypesListQueryHandler : IRequestHandler<GetQuestionTypesListQuery, object>
    {
        private readonly EMSContext eMSContext;
        public GetQuestionsTypesListQueryHandler(EMSContext eMSContext)
        {
            this.eMSContext = eMSContext;
        }
        public async Task<object> Handle(GetQuestionTypesListQuery request, CancellationToken cancellationToken)
        {
            var questionTypes = await eMSContext.QuestionType
                .Select(x => new
                {
                    ID = x.Id,
                    Name = x.Name
                }).ToListAsync();

            return questionTypes;
        }
    }
}
