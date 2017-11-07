using System;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public class ReadImageFileInfo : IReadImageFileInfo
    {
        public bool CheckIsFileExist(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool CheckIsFileEmpty(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetImageExtension(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool CheckIsFileImageExtension(string fileContentType)
        {
            if (!String.IsNullOrEmpty(fileContentType))
            {
                switch (fileContentType)
                {
                    case "image/png":
                        return true;
                    case "image/jpeg":
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}