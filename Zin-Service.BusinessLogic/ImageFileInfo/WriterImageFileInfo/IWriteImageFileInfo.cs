using System;
using System.Web;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteImageFileInfo
    {
        void WriteImageFileName(string fileName);
        void WriteImageFileExtension(string fileName, string contentType);
        //void StoreImageFile(HttpPostedFileBase file);
    }
}