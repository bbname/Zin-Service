using Moq;
using NUnit.Framework;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;
using Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo;
using Zin_Service.WebUI.Controllers;

namespace Zin_Service.Tests.WebUI.Controllers
{
    [TestFixture]
    public class ImageControllerTest
    {
        [Test]
        public void UploadImage_UploadedFileIsNull_ExceptionThrown()
        {
            // Arrange
            var readImageFileInfo = new Mock<IReadImageFileInfo>();
            var writeImageFileInfo = new Mock<IWriteImageFileInfo>();
            var controller = new ImageController(readImageFileInfo.Object, writeImageFileInfo.Object);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile = null;

            //var httpContext = new Mock<HttpContextBase>();
            //var server = new Mock<HttpServerUtilityBase>();
            //server.Setup(s => s.MapPath("~/Images/Uploaded"))
            //    .Returns(@"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\");
            //httpContext.Setup(h => h.Server).Returns(server.Object);

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => controller.UploadImage(uploadedFile.Object));
        }
    }
}