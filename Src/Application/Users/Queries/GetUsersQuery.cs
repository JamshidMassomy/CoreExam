using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Login.Queries
{
    public class GetUsersQuery:IRequest<object>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
    public class GetUserQueryHandler : IRequestHandler<GetUsersQuery, object>
    {
        private readonly EMSContext EMSContext;
        public GetUserQueryHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var _users = await EMSContext.Users.Select(u =>  
            new { 
                Name = request.Name,
                Email  = request.Email,
                Phone = request.Phone
                
            }).ToListAsync();
            return _users;
        }
    }
}
