using System;
using System.Web;

namespace Zin_Service.Service.Upload
{
    public class WriteUploadedImage : IWriteUploadedImage
    {
        public DateTime UploadedTime { get; set; }

        public void StoreUploadedImage(HttpPostedFileBase file)
        {
            throw new NotImplementedException();
        }
    }
}