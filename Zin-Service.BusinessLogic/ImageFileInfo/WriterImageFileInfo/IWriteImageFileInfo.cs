using System;
using System.Web;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteImageFileInfo
    {
        void ChangeFileName(string fileName);
        void WriteImageFileExtension(string fileName, string contentType);
    }
}