using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using XM.Application.Photo.Command;
using Microsoft.AspNetCore.Hosting;
using XM.Application.Photo.Queris;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace Exam.Controllers
{
    public class FileController : BaseController
    {
        private readonly IHostingEnvironment hostingEnvironment;
        //private readonly IFormFile File;
        public FileController(IHostingEnvironment _hostingEnv/*, IFormFile _File*/)
        {
          //  this.File = _File;
            this.hostingEnvironment = _hostingEnv;
        }
        [HttpPost("SavePhoto")]
        public IActionResult SavePhoto(/*int RecordId, string FileName, string Path,*/ [FromBody]SavePhotoCommand photo)
        {
            if (photo.File.Length > 0)
            {
                using (var fileStream = new FileStream(photo.FileName, FileMode.Create))
                {
                    photo.File.CopyTo(fileStream);
                    //Path.Combine("wwwroot/xmphoto", photo.File.FileName);
                }
            }


            //string name = photo.FileName;
            //var img = photo.file;
            //Path.Combine("wwwroot/images", img.FileName);
            //if (img.Length > 0)
            //{
            //    using (var fileStream = new FileStream(img.FileName, FileMode.Create))
            //    {
            //        img.CopyTo(fileStream);
            //        Path.Combine("wwwroot/images",img.FileName);
            //    }
            //}

            //var folderPath = System.IO.Path.Combine(hostingEnvironment.ContentRootPath, "xmphoto");
            //if (!System.IO.Directory.Exists(folderPath))
            //{
            //    System.IO.Directory.CreateDirectory(folderPath);
            //}
            //System.IO.File.WriteAllBytes((folderPath, FileName), Convert.FromBase64String(base64img));

            //var imgByte = Convert.FromBase64String(photo.Base64);
            //var imgStream = new MemoryStream(imgByte);
            //imgStream.Position = 0;
            //File(imgByte, "img/jpg");

            //Mediator.Send(new SavePhotoCommand { RecordId = RecordId , FileName = FileName, Path = Path });
            // return Ok(Mediator.Send(photo));
            return Ok();
        }
        [HttpGet("GetPhotos")]
        public async Task<IActionResult> GetPhoto()
        {
            return Ok(await Mediator.Send(new GetPhotoQuery()));
        }


    }
    
}