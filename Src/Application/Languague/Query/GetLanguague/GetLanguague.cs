using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Languague.Query.GetLanguague
{
    public class GetLanguagueQuery:IRequest<object>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class GetLanguagueHandler : IRequestHandler<GetLanguagueQuery, object>
    {
        private readonly EMSContext eMSContext;
        public GetLanguagueHandler(EMSContext _eMSContext)
        {
            this.eMSContext = _eMSContext;
        }
        public async Task<object> Handle(GetLanguagueQuery request, CancellationToken cancellationToken)
        {
            var _lang = await eMSContext.Languague
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name

                }).ToListAsync();
            return _lang;
        }
    }
}
