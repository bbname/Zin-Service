using System;
using System.IO;
using System.Web;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public class WriteUploadedImageFileInfo : WriteImageFileInfo ,IWriteUploadedImageFileInfo
    {
        private readonly IReadUploadedImageFileInfo _readUploadedImageFileInfo;
        public WriteUploadedImageFileInfo(IReadUploadedImageFileInfo readUploadedImageFileInfo) 
        {
            _readUploadedImageFileInfo = readUploadedImageFileInfo;
        }

        public void StoreUploadedImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (_readUploadedImageFileInfo.CheckIsFileImageExtension(file.ContentType))
                {
                    throw new NotImplementedException();
                }
                else
                {
                    throw new InvalidDataException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}