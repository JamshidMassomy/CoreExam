using Domain.DBContext;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XM.Application.Photo.Queris
{
    public class GetPhotoQuery:IRequest<object>
    {
       public int recordID { get; set; }
    }
    public class GetPhotHandler : IRequestHandler<GetPhotoQuery, object>
    {
        private readonly EMSContext eMSContext;
        public GetPhotHandler(EMSContext _emsContext)
        {
            this.eMSContext = _emsContext;
        }
        public async Task<object> Handle(GetPhotoQuery request, CancellationToken cancellationToken)
        {
            var photos = await eMSContext.Photo
                .Select(x => new
                {
                    Id= x.Id,
                    RecordId= x.RecordId,
                    FileName=x.FileName,
                    Path=x.Path,
                    Base64 = x.Base64
                    
                }).ToListAsync();

            return photos;
        }
    }
}
