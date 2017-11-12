using System;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;
using Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo;

namespace Zin_Service.WebUI.Controllers
{
    public class ImageController : Controller
    {
        private readonly IReadUploadedImageFileInfo _readUploadedImageFileInfo;
        private readonly IWriteUploadedImageFileInfo _writeUploadedImageFileInfo;
        public ImageController(IReadUploadedImageFileInfo readUploadedImageFileInfo, IWriteUploadedImageFileInfo writeUploadedImageFileInfo)
        {
            _readUploadedImageFileInfo = readUploadedImageFileInfo;
            _writeUploadedImageFileInfo = writeUploadedImageFileInfo;
        }

        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase uploadedFile)
        {
            try
            {
                _writeUploadedImageFileInfo.StoreUploadedImage(uploadedFile);
                return new HttpStatusCodeResult(HttpStatusCode.Accepted);
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }

        public void GenerateFilterImage()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public FileResult DownloadImage()
        {
            throw new NotImplementedException();
        }
    }
}