using Moq;
using NUnit.Framework;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Zin_Service.Service.GeneratorImageName;
using Zin_Service.Service.Upload;
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
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            IWriteUploadedImage writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
            var controller = new ImageController(readUploadedImage, writeUploadedImage);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile = null;

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => controller.UploadImage(uploadedFile.Object));
        }
    }
}