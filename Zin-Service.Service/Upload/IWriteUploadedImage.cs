using System;
using System.Web;

namespace Zin_Service.Service.Upload
{
    public interface IWriteUploadedImage
    {
        DateTime UploadedTime { get; set; }
        void StoreUploadedImage(HttpPostedFileBase file);
    }
}