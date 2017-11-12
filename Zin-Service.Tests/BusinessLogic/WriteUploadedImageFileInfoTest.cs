using System;
using System.IO;
using System.Web;
using Moq;
using NUnit.Framework;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;
using Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class WriteUploadedImageFileInfoTest
    {
        [Test]
        public void StoreImageFile_FileIsNull_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo);

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImageFileInfo.StoreUploadedImage(null));
        }

        [Test]
        public void StoreImageFile_FileIsTxt_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo);
            //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\jakistam.txt.txt";
            var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\jakistam.txt.txt";
            var fileStream = new FileStream(path, FileMode.Open);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("jakistam.txt");
            uploadedFile.Setup(f => f.ContentType).Returns("text/plain");
            uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.Throws<InvalidDataException>(() => writeUploadedImageFileInfo.StoreUploadedImage(uploadedFile.Object));
            fileStream.Close();
            fileStream.Dispose();
        }

        [Test]
        public void StoreImageFile_FileIsPng_NotImplementedException()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo);
            //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\owczarek.png";
            var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\owczarek.png";
            var fileStream = new FileStream(path, FileMode.Open);
            var stream = new Mock<HttpPostedFileWrapper>();
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("owczarek.png");
            uploadedFile.Setup(f => f.ContentType).Returns("image/png");
            uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.Throws<NotImplementedException>(() => writeUploadedImageFileInfo.StoreUploadedImage(uploadedFile.Object));
            fileStream.Close();
            fileStream.Dispose();
        }
    }
}