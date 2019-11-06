using Domain.DBContext;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Photo.Command
{
    public class SavePhotoCommand:IRequest<object>
    {
        public int RecordId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Base64 { get; set; }
        public IFormFile File { get; set; }

    }
    public class SavePhotoHandler : IRequestHandler<SavePhotoCommand, object>
    {
        private readonly EMSContext eMSContext;
        public SavePhotoHandler(EMSContext _eMSContext)
        {
            this.eMSContext = _eMSContext;
        }
        public async Task<object> Handle(SavePhotoCommand request, CancellationToken cancellationToken)
        {
            var _photo =  new Models.Entity.Photo
            {
                RecordId = request.RecordId,
                FileName = request.FileName,
                Path = request.Path,
                Base64 = request.Base64,
                File = request.File  
            };
            await eMSContext.AddAsync(_photo);
            await eMSContext.SaveChangesAsync();
            return _photo;
        }
    }
}
