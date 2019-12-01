using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Test.Queries
{
    public class GetTestTypes:IRequest<object>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class GetTestTypesHandler : IRequestHandler<GetTestTypes, object>
    {
        private readonly EMSContext EMSContext;
        public GetTestTypesHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(GetTestTypes request, CancellationToken cancellationToken)
        {
            var _test = await EMSContext.Test
                .Select(t => new
                {
                    t.Id,
                    t.Name
                }).ToListAsync();
            return _test;
        }
    }
}
