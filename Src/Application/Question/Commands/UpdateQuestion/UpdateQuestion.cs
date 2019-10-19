
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain.DBContext;
using System.Linq;

namespace XM.Application.Question.Commands.UpdateQuestion
{
    public class UpdateQuestion:IRequest<object>
    {
        public int ID { get; set; }
        public string Lebel { get; set; }
        public int CategoryID { get; set; }
        public int Point { get; set; }
        public bool IsActive { get; set; }
    }

    public class UpdateQuestionHandler : IRequestHandler<UpdateQuestion, object>
    {
        private readonly EMSContext EMSContext;
        public UpdateQuestionHandler(EMSContext _EMSContext)
        {
            this.EMSContext = _EMSContext;
        }
        public async Task<object> Handle(UpdateQuestion request, CancellationToken cancellationToken)
        {
            var _Question = EMSContext.Question.Where(x => x.Id == request.ID).FirstOrDefault();
            //TODO check null and validate
            _Question.Lebel = request.Lebel;
            _Question.Point = request.Point;
            _Question.IsActive = request.IsActive;
            _Question.CategoryId = request.CategoryID;
            await EMSContext.SaveChangesAsync(cancellationToken);
            return (_Question);
            //throw new System.NotImplementedException();
        }
    }
}
