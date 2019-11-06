using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.QuestionCategory.Queries
{
    public class GetQuestionCategoryQuery:IRequest<object>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class GetQuestionCategoryHandler : IRequestHandler<GetQuestionCategoryQuery, object>
    {
        private readonly EMSContext eMSContext;
        public GetQuestionCategoryHandler(EMSContext _eMSContext)
        {
            this.eMSContext = _eMSContext;
        }
        public async Task<object> Handle(GetQuestionCategoryQuery request, CancellationToken cancellationToken)
        {
            var cat = await eMSContext.Category
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name

                }).ToListAsync();
            return cat;
        }
    }

}
