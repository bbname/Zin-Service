using System;
using System.IO;
using System.Web;
using Zin_Service.Service.GeneratorImageName;
using Zin_Service.Service.WriterImage;

namespace Zin_Service.Service.Upload
{
    public class WriteUploadedImage : WriteImage, IWriteUploadedImage
    {
        private readonly IReadUploadedImage _readUploadedImage;
        private readonly IGenerateImageName _generateImageName;

        public WriteUploadedImage(IReadUploadedImage readUploadedImage, IGenerateImageName generateImageName)
        {
            _readUploadedImage = readUploadedImage;
            _generateImageName = generateImageName;
        }
        public void StoreUploadedImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (_readUploadedImage.CheckIsFileImageExtension(file.ContentType))
                {
                    //var spath = HttpContext.Current.Server.MapPath("~/Images/Uploaded");
                    var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";
                    //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\jakistam.txt.txt";
                    var cpath = Path.Combine(path, Path.GetFileName(file.FileName));
                    try
                    {
                        file.SaveAs(cpath);
                        ChangeFileName(file.FileName);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
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

        public override void ChangeFileName(string uploadedFileName)
        {
            if (!String.IsNullOrEmpty(uploadedFileName))
            {
                //var Spath = HttpContext.Current.Server.MapPath("~/Images/Uploaded");
                var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";
                //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\";
                var guid = _generateImageName.GenerateName();
                var imageExtension = Path.GetExtension(path + uploadedFileName);

                if (!String.IsNullOrEmpty(guid) && !String.IsNullOrEmpty(imageExtension))
                {
                    string generatedFileName = String.Concat(guid, imageExtension);
                    File.Move(path + uploadedFileName, path + generatedFileName);
                }
                else
                {
                    throw new ApplicationException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}