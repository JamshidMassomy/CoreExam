using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using XM.Application.Question.Commands.CreateQuestion;
using XM.Application.Question.Commands.UpdateQuestion;
using XM.Application.Question.Queries.GetQuestions.GetQuestionList;
using XM.Models.Entity;

namespace Exam.Controllers
{
    public class QuestionController : BaseController
    {
        //private readonly IHostingEnvironment hostingEnvironment;
        //public QuestionController(IHostingEnvironment _hostingEnv)
        //{

        //}
        [HttpPost("CreateQuestion")]
        public async Task<IActionResult> Create([FromBody] CreateQuestion createQuestionCommand)
        {
            //var imgByte = Convert.FromBase64String(createQuestionCommand.Image);
           // var imgStream = new MemoryStream(imgByte);
            //imgStream.Position = 0;
            return Ok(await Mediator.Send(createQuestionCommand));
        }
        [HttpGet("GetQuestions")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetQuestionQuery()));
        }
        [HttpPost("UpdateQuestion")]
        public async Task<IActionResult> Update(UpdateQuestion _updateQuestion)
        {
            return Ok(await Mediator.Send(_updateQuestion));
            //throw  await new NotImplementedException;
        }
    }
}