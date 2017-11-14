using System;
using System.IO;
using System.Web;
using Zin_Service.BusinessLogic.GeneratorImageName;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public class WriteUploadedImageFileInfo : WriteImageFileInfo ,IWriteUploadedImageFileInfo
    {
        private readonly IReadUploadedImageFileInfo _readUploadedImageFileInfo;
        private readonly IGenerateImageName _generateImageName;
        public WriteUploadedImageFileInfo(IReadUploadedImageFileInfo readUploadedImageFileInfo, IGenerateImageName generateImageName) 
        {
            _readUploadedImageFileInfo = readUploadedImageFileInfo;
            _generateImageName = generateImageName;
        }

        public override void ChangeFileName(string uploadedFileName)
        {
            if (!String.IsNullOrEmpty(uploadedFileName))
            {
                //var Spath = HttpContext.Current.Server.MapPath("~/Images/Uploaded");
                var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";
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

        public void StoreUploadedImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (_readUploadedImageFileInfo.CheckIsFileImageExtension(file.ContentType))
                {
                    //var spath = HttpContext.Current.Server.MapPath("~/Images/Uploaded");
                    var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\";
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
    }
}