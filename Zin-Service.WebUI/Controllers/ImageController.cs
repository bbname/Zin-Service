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
            }
            catch (Exception e)
            {
                return View("Error", e);
            }

            return Json(@"Content/histogram.jpg",
                JsonRequestBehavior.AllowGet);
            //return Json(Server.MapPath("/Content/histogram.jpg"),
            //    JsonRequestBehavior.AllowGet);
            //return Json(@"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\histogram.jpg",
            //    JsonRequestBehavior.AllowGet);
            //return new JsonResult()
            //{
            //    Data = new { response = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\histogram.jpg" }
            //};
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