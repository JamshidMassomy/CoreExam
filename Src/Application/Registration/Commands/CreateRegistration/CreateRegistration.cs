using Domain.DBContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Registration.Commands.CreateRegistration
{
    public class CreateRegistration:IRequest<object>
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public int GenderID { get; set; }
        public int TestID { get; set; }
        public int AccessLevelID { get; set; }
        public DateTime RegistrationDate { get; set; } 
        public DateTime TokenExpiry { get; set; }
    }
    public class CreateApplicantHandler : IRequestHandler<CreateRegistration, object>
    {
        private readonly EMSContext eMSContext;
        public  CreateApplicantHandler(EMSContext _EMSContext)
        {
            this.eMSContext = _EMSContext;
        }
        public async Task<object> Handle(CreateRegistration request, CancellationToken cancellationToken)
        {
            var _Student = new Models.Entity.Student
            {
                Name = request.Name,
                FatherName= request.FatherName,
                GenderId = request.GenderID,
                Nid = request.Nid,
                Email = request.Email,
                Phone = request.Phone
            };
            await eMSContext.AddAsync(_Student);
            await eMSContext.SaveChangesAsync();

            var _Registration = new Models.Entity.Registration {
                StudentId = _Student.Id,
                TestId = request.TestID,
                Toaken = request.Token,
                AccessLevelId = request.AccessLevelID,
                RegistrationDate = DateTime.Now,
                TokenExpireTime = DateTime.Now.AddDays(1)                
            };
            await eMSContext.AddAsync(_Registration);
            await eMSContext.SaveChangesAsync();
            return _Registration;
        }
    }
}
