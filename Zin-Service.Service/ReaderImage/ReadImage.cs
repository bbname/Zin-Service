using System;

namespace Zin_Service.Service.ReaderImage
{
    public abstract class ReadImage : IReadImage
    {
        public abstract bool CheckIsFileExist(string fileName);
        public abstract string GetImageExtension(string fileName);
        public abstract byte[] GetImage(string fileName);
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