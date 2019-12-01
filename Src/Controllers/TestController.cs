using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XM.Application.Test.Commands.CreateTests;

namespace Exam.Controllers
{
    public class TestController : BaseController
    {
        [HttpPost("CreateTest")]
        public async Task<IActionResult> Create([FromBody] CreateTest createTest)
        {
            return Ok(await Mediator.Send(createTest));
        }
    }
}