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

        [Test]
        public void UploadImage_UploadedFileIsPng_ExceptionThrown()
        {
            // Arrange
            var readImageFileInfo = new Mock<IReadImageFileInfo>();
            var writeImageFileInfo = new Mock<IWriteImageFileInfo>();
            var controller = new ImageController(readImageFileInfo.Object, writeImageFileInfo.Object);
            var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\rozklad.png";
            var fileStream = new FileStream(path, FileMode.Open);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("rozklad.png");
            uploadedFile.Setup(f => f.ContentType).Returns("image/png");
            uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.Throws<InvalidDataException>(() => controller.UploadImage(uploadedFile.Object));
            fileStream.Close();

        }
    }
}