using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XM.Application.Registration.Commands.CreateRegistration;
using XM.Models.Entity;

namespace Exam.Controllers
{
    public class RegistrationController : BaseController
    {
        [HttpPost("Registration")]
       public async Task<IActionResult> Create([FromBody] CreateRegistration createRegistration  )
        {
            return Ok(await Mediator.Send(createRegistration));
        }
    }
}