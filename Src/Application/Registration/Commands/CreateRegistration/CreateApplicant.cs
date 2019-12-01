using Domain.DBContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Registration.Commands.CreateRegistration
{
    public class CreateApplicant:IRequest<object>
    {
        public string OTP { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public bool? Gender { get; set; }
        public int TestID { get; set; }
        public DateTime RegistrationDate { get; set; } 
        public DateTime TokenExpiry { get; set; }
    }
    public class CreateApplicantHandler : IRequestHandler<CreateApplicant, object>
    {
        private readonly EMSContext eMSContext;
        public  CreateApplicantHandler(EMSContext _EMSContext)
        {
            this.eMSContext = _EMSContext;
        }
        public Task<object> Handle(CreateApplicant request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
