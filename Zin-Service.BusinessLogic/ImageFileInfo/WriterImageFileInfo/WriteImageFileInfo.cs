using System;
using System.IO;
using System.Web;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public class WriteImageFileInfo : IWriteImageFileInfo
    {
        public virtual void ChangeFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteImageFileExtension(string fileName, string contentType)
        {
            throw new NotImplementedException();
        }
    }
}