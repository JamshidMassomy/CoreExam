using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.GenderTypes.Queries
{
    public class GetGenderTypesQueries:IRequest<object>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class GetGenderTypesQuriesHandler : IRequestHandler<GetGenderTypesQueries, object>
    {
        private readonly EMSContext EMSContext;
        public GetGenderTypesQuriesHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(GetGenderTypesQueries request, CancellationToken cancellationToken)
        {
            var _Genders = await EMSContext.Genders.
                Select(g => new
                {
                    g.Id,
                    g.Name
                }).ToListAsync();
            return _Genders;
        }
    }
}
