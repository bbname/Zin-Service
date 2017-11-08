using System;
using System.IO;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public class ReadImageFileInfo : IReadImageFileInfo
    {
        public bool CheckIsFileExist(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public string GetImageExtension(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                if (CheckIsFileExist(fileName))
                {
                    throw new NotImplementedException();
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public string GetFileName(string fullFileName)
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
                throw new ArgumentNullException();
            }
        }
    }
}