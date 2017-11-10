using System;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Web;
using System.Web.UI.WebControls;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public class ReadImageFileInfo : IReadImageFileInfo
    {
        public virtual bool CheckIsFileExist(string fileName)
        {
            throw new NotImplementedException();
        }

        public virtual string GetImageExtension(string fileName)
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