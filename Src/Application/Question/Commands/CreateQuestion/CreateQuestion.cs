using Domain.DBContext;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using XM.Models.Entity;

namespace XM.Application.Question.Commands.CreateQuestion
{
    public class CreateQuestion: IRequest<object>
    {
        public int QuestionTypeID { get; set; }
        public int CategoryID { get; set; }
        public string Lebel { get; set; }
        public int Point { get; set; }
        public bool isActive { get; set; }
        public string Choice1 { get; set; }
        public int Choice1Score { get; set; }
        public string Choice2 { get; set; }
        public int Choice2Score { get; set; }
        public string Choice3 { get; set; }
        public int Choice3Score { get; set; }
        public string Choice4 { get; set; }
        public int Choice4Score { get; set; }
        //public IFormFile File { get; set; }       
        public string FileName { get; set; }
        public string Base64 { get; set; }
    }
    public class CreateQuestionHandler : IRequestHandler<CreateQuestion, object>
    {
        private readonly EMSContext EMSContext;
        private readonly IHostingEnvironment hostingEnvironment;
        //private readonly IFormFile File;
       
        public CreateQuestionHandler(EMSContext _EMSContext, IHostingEnvironment _hostingEnv)
        {
            this.EMSContext = _EMSContext;
            this.hostingEnvironment = _hostingEnv;
        }
        public async Task Post(IFormFile file)
        {
            var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
        }
        public async Task<object> Handle(CreateQuestion request, CancellationToken cancellationToken)
        {
            var Question = new Models.Entity.Question
            {
                CategoryId = request.CategoryID,
                QuestionTypeId = request.QuestionTypeID,
                Lebel = request.Lebel,
                Point = request.Point,
                IsActive = request.isActive
            };
            await EMSContext.AddAsync(Question);
            await EMSContext.SaveChangesAsync(cancellationToken);

            var img = new Models.Entity.Photo
            {
                FileName =request.FileName,
                RecordId =Question.Id,
                Base64 = request.Base64
            };
            await EMSContext.AddAsync(img);
            await EMSContext.SaveChangesAsync(cancellationToken);

            IList<Choice> Choices =  new List<Choice> { 
                new Choice{QuestionId = Question.Id , Label = request.Choice1, Points = request.Choice1Score },
                new Choice{QuestionId = Question.Id , Label = request.Choice2, Points = request.Choice2Score },
                new Choice{QuestionId = Question.Id , Label = request.Choice3, Points = request.Choice3Score },
                new Choice{QuestionId = Question.Id , Label = request.Choice4, Points = request.Choice4Score }
            };
            await EMSContext.AddRangeAsync(Choices);
            await EMSContext.SaveChangesAsync();




            //EMSContext.Model.en
            
            //await EMSContext.AddAsync(Choices);
            //await EMSContext.SaveChangesAsync(cancellationToken);
            return new
            {
                Message = "New Question Type added."
            };
        }
        
    }
}
