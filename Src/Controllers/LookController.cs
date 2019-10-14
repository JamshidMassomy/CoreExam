using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XM.Application.QuestionType.Commands.CreateQuestionType;
using XM.Application.QuestionType.Queries.GetQuestionTypeById;
using XM.Application.QuestionType.Queries.GetQuestionTypesList;

namespace Exam.Controllers
{
    public class LookController : BaseController
    {
        [HttpGet("QuestionTypes")]
        public async Task<IActionResult> GetQuestionTypes()
        {
            var questionTypes = await Mediator.Send(new GetQuestionTypesListQuery());
            return Ok(questionTypes);
        }
        [HttpGet("QuestionType/{id}")]
        public async Task<IActionResult> GetQuestionTypes(int id)
        {
            var questionType = await Mediator.Send(new GetQuestionTypeByIdQuery{ Id = id});
            return Ok(questionType);
        }

        [HttpPost("CreateQuestionType")]
        public async Task<IActionResult> CreateQuestionType([FromBody] CreateQuestionTypeCommand createQuestionTypeCommand)
        {
            return Ok(await  Mediator.Send(createQuestionTypeCommand));
        }
    }
}