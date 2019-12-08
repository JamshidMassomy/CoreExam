using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Users.Queries
{
    public class GetLoginQuery:IRequest<object>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class GetLoginQueryHandler : IRequestHandler<GetLoginQuery, object>
    {
        private readonly EMSContext EMSContext;
        public GetLoginQueryHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(GetLoginQuery request, CancellationToken cancellationToken)
        {
            
            var _users = await EMSContext.Users.Select(a =>
            new
            {
                UserName = request.UserName,
                Password = request.Password
            }).ToListAsync();
            return _users;
        }
    }
}
