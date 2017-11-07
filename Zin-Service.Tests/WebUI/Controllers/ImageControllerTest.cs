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
            IReadImageFileInfo readImageFileInfo = new ReadImageFileInfo();
            IWriteImageFileInfo writeImageFileInfo = new WriteImageFileInfo(readImageFileInfo);
            var controller = new ImageController(readImageFileInfo, writeImageFileInfo);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile = null;

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => controller.UploadImage(uploadedFile.Object));
        }
    }
}