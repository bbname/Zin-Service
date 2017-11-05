using Moq;
using NUnit.Framework;
using System.Web;
using Zin_Service.WebUI.Controllers;

namespace Zin_Service.Tests.WebUI.Controllers
{
    [TestFixture]
    public class ImageControllerTest
    {
        public void UploadImage_UploadedFileIsNull_ExceptionThrown()
        {
            // Arrange
            var controller = new ImageController();
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile = null;

            // Act
            controller.UploadImage(uploadedFile);

            // Assert

        }
    }
}