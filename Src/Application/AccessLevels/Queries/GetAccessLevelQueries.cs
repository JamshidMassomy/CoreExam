using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.AccessLevels.Queries
{
    public class GetAccessLevelQueries:IRequest<object>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class GetAccessLevel : IRequestHandler<GetAccessLevelQueries, object>
    {
        private readonly EMSContext eMSContext;
        public GetAccessLevel(EMSContext _EMSContext)
        {
            this.eMSContext = _EMSContext;
        }
        public async Task<object> Handle(GetAccessLevelQueries request, CancellationToken cancellationToken)
        {
            var _levels = await eMSContext.AccessLevels
                .Select(l => new
                {
                    l.Id,
                    l.Name

                }).ToListAsync();
            return _levels;
        }
    }
}
