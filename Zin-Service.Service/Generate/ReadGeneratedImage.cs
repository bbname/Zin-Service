using System;
using System.IO;
using System.Web;
using Zin_Service.Service.ReaderImage;

namespace Zin_Service.Service.Generate
{
    public class ReadGeneratedImage : ReadImage, IReadGeneratedImage
    {
        public override bool CheckIsFileExist(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {

                //var path = @"E:\PROJEKTY\Zin-Service Images\Generated\";
                var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Generated\";

                //var appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"~\Images\Generated\");
                //var serverPath = HttpContext.Current.Server.MapPath(@"~/Images/Generated");

                return File.Exists(path + fileName) ? true : false;

            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public override string GetImageExtension(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                if (CheckIsFileExist(fileName))
                {
                    var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Generated\";
                    //var path = @"E:\PROJEKTY\Zin-Service Images\Generated\";
                    var extension = MimeMapping.GetMimeMapping(path + fileName);

                    if (!String.IsNullOrEmpty(extension))
                    {
                        return extension;
                    }
                    else
                    {
                        throw new ApplicationException();
                    }
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

        public override byte[] GetImage(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}