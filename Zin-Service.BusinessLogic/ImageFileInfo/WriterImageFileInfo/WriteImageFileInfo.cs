using System;
using System.IO;
using System.Web;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public class WriteImageFileInfo : IWriteImageFileInfo
    {
        //private readonly IReadImageFileInfo _readImageFileInfo;
        //public WriteImageFileInfo(IReadImageFileInfo readImageFileInfo)
        //{
        //    _readImageFileInfo = readImageFileInfo;
        //}
        public virtual void WriteImageFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteImageFileExtension(string fileName, string contentType)
        {
            throw new NotImplementedException();
        }

        //public void StoreImageFile(HttpPostedFileBase file)
        //{
        //    if (file != null)
        //    {
        //        if (_readImageFileInfo.CheckIsFileImageExtension(file.ContentType))
        //        {
        //            throw new NotImplementedException();
        //        }
        //        else
        //        {
        //            throw new InvalidDataException();
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentNullException();
        //    }
        //}
    }
}