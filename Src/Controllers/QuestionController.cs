
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using XM.Application.Question.Commands.CreateQuestion;
using XM.Application.Question.Commands.UpdateQuestion;
using XM.Application.Question.Queries.GetQuestions.GetQuestionList;
using XM.Models.Entity;

namespace Exam.Controllers
{
    public class QuestionController : BaseController
    {
        [HttpPost("CreateQuestion")]
        public async Task<IActionResult> Create([FromBody] CreateQuestion createQuestionCommand)
        {
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
        }
    }
}