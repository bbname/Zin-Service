using System;
using System.Web;
using System.Web.Mvc;

namespace Zin_Service.WebUI.Controllers
{
    public class ImageController : Controller
    {

        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase uploadedFile)
        {
            if (uploadedFile != null)
            {
                if ()
                {
                    
                }
            }
            else
            {
                throw new NullReferenceException();
            }
            //throw new NotImplementedException();
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