using System;
using System.Web;

namespace Zin_Service.Service.Upload
{
    public interface IWriteUploadedImage
    {
        void StoreUploadedImage(HttpPostedFileBase file);
    }
}