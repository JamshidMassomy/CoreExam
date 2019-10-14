using MediatR;

namespace XM.Application.QuestionType.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommand: IRequest<object>
    {
        public string Name { get; set; }
    }
}
