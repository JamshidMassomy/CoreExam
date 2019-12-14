using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XM.Application.AccessLevels.Queries;
using XM.Application.GenderTypes.Queries;
using XM.Application.Languague.Query.GetLanguague;
using XM.Application.QuestionCategory.Queries;
using XM.Application.QuestionType.Commands.CreateQuestionType;
using XM.Application.QuestionType.Queries.GetQuestionTypeById;
using XM.Application.QuestionType.Queries.GetQuestionTypesList;
using XM.Application.Test.Queries;

namespace Exam.Controllers
{

    public class LookController : BaseController
    {
        [Authorize]
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
        [HttpGet("QuestionCategory")]
        public async Task<IActionResult> GetQuestionCategory()
        {
            return Ok(await Mediator.Send(new GetQuestionCategoryQuery()));
        }
        [HttpGet("GetLanguague")]
        public async Task<IActionResult> GetLanguague() {
            return Ok(await Mediator.Send(new GetLanguagueQuery()));
        }
        [HttpGet("GetTestTypes")]
        public async Task<IActionResult> GetTests()
        {
            return Ok(await Mediator.Send(new GetTestTypes()));
        }
        [HttpGet("GetGenderTypes")]
        public async Task<IActionResult> GetGenders()
        {
            return Ok(await Mediator.Send(new GetGenderTypesQueries()));
        }
        [HttpGet("GetAccessLevels")]
        public async Task<IActionResult> GetAccessLevels()
        {
            return Ok(await Mediator.Send(new GetAccessLevelQueries()));
        }
    }
}