using Moq;
using NUnit.Framework;
using System;
using System.Web;
using System.Web.Mvc;
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
            var controller = new ImageController();
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile = null;

            //var httpContext = new Mock<HttpContextBase>();
            //var server = new Mock<HttpServerUtilityBase>();
            //server.Setup(s => s.MapPath("~/Images/Uploaded"))
            //    .Returns(@"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\");
            //httpContext.Setup(h => h.Server).Returns(server.Object);

            // Act

            // Assert
            Assert.Throws<NullReferenceException>(() => controller.UploadImage(uploadedFile.Object));
        }
    }
}