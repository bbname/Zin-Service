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
    public class WriteImageFileInfoTest
    {
        [Test]
        public void StoreImageFile_FileIsNull_ExceptionThrown()
        {
            // Arrange
            IReadImageFileInfo readImageFileInfo = new ReadImageFileInfo();
            var writeImageFileInfo = new WriteImageFileInfo(readImageFileInfo);
            var fileUploaded = new Mock<HttpPostedFileBase>();
            fileUploaded = null;

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => writeImageFileInfo.StoreImageFile(fileUploaded.Object));
        }

        [Test]
        public void StoreImageFile_FileIsTxt_ExceptionThrown()
        {
            // Arrange
            IReadImageFileInfo readImageFileInfo = new ReadImageFileInfo();
            var writeImageFileInfo = new WriteImageFileInfo(readImageFileInfo);
            //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\jakistam.txt.txt";
            var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\jakistam.txt.txt";
            var fileStream = new FileStream(path, FileMode.Open);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("jakistam.txt");
            uploadedFile.Setup(f => f.ContentType).Returns("text/plain");
            uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.Throws<InvalidDataException>(() => writeImageFileInfo.StoreImageFile(uploadedFile.Object));
            fileStream.Close();
            fileStream.Dispose();
        }

        [Test]
        public void StoreImageFile_FileIsPng_NotImplementedException()
        {
            // Arrange
            IReadImageFileInfo readImageFileInfo = new ReadImageFileInfo();
            var writeImageFileInfo = new WriteImageFileInfo(readImageFileInfo);
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
            Assert.Throws<NotImplementedException>(() => writeImageFileInfo.StoreImageFile(uploadedFile.Object));
            fileStream.Close();
            fileStream.Dispose();
        }
    }
}