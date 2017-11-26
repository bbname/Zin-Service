using System;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zin_Service.Service.Upload;

namespace Zin_Service.WebUI.Controllers
{
    public class ImageController : Controller
    {
        private readonly IReadUploadedImage _readUploadedImage;
        private readonly IWriteUploadedImage _writeUploadedImage;
        public ImageController(IReadUploadedImage readUploadedImage, IWriteUploadedImage writeUploadedImage)
        {
            _readUploadedImage = readUploadedImage;
            _writeUploadedImage = writeUploadedImage;
        }

        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase uploadedFile)
        {
            try
            {
                _writeUploadedImage.StoreUploadedImage(uploadedFile);
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