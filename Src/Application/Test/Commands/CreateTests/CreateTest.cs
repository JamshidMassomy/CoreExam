using Domain.DBContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Test.Commands.CreateTests
{
    public class CreateTest:IRequest<object>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int DurationInMinutes { get; set; }
    }
    public class CreateTestHandler : IRequestHandler<CreateTest, object>
    {
        private readonly EMSContext EMSContext;
        public CreateTestHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(CreateTest request, CancellationToken cancellationToken)
        {
            var Test = new Models.Entity.Test {
                Name =request.Name,
                Description = request.Description,
                IsActive = request.IsActive,
                DurationInMinutes = request.DurationInMinutes
            };
            await EMSContext.AddAsync(Test);
            await EMSContext.SaveChangesAsync(cancellationToken);
            return Test;
        }
    }
}
