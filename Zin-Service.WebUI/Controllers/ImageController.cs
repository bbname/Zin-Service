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
        private readonly IReadImageFileInfo _readImageFileInfo;
        private readonly IWriteImageFileInfo _writeImageFileInfo;
        public ImageController(IReadImageFileInfo readImageFileInfo, IWriteImageFileInfo writeImageFileInfo)
        {
            _readImageFileInfo = readImageFileInfo;
            _writeImageFileInfo = writeImageFileInfo;
        }

        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase uploadedFile)
        {
            try
            {
                _writeImageFileInfo.StoreImageFile(uploadedFile);
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