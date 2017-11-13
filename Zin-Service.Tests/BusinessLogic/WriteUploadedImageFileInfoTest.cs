using System;
using System.IO;
using System.Web;
using Moq;
using NUnit.Framework;
using Zin_Service.BusinessLogic.GeneratorImageName;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;
using Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class WriteUploadedImageFileInfoTest
    {

        [Test]
        public void ChangeFileName_StringIsNull_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);
            string uploadedFileName = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImageFileInfo.ChangeFileName(uploadedFileName));

        }

        [Test]
        public void ChangeFileName_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);
            string uploadedFileName = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImageFileInfo.ChangeFileName(uploadedFileName));

        }

        [Test]
        public void ChangeFileName_StringIsowczarekpng_ChangedFileName()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);
            string uploadedFileName = "owczarek.png";

            // Act 
            writeUploadedImageFileInfo.ChangeFileName(uploadedFileName);

            // Assert
            Assert.IsFalse(readUploadedImageFileInfo.CheckIsFileExist(uploadedFileName));


        }

        [Test]
        public void StoreUploadedImage_FileIsNull_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImageFileInfo.StoreUploadedImage(null));
        }

        [Test]
        public void StoreUploadedImage_FileIsTxt_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);
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
        public void StoreUploadedImage_FileIsPng_NotImplementedException()
        {
            // Arrange
            IReadUploadedImageFileInfo readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImageFileInfo = new WriteUploadedImageFileInfo(readUploadedImageFileInfo, generateImageName);
            //var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\owczarek.png";
            //var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\owczarek.png";
            //var fileStream = new FileStream(path, FileMode.Open);
            var stream = new Mock<HttpPostedFileWrapper>();
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("owczarek.png");
            uploadedFile.Setup(f => f.ContentType).Returns("image/png");
            //uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.IsFalse(readUploadedImageFileInfo.CheckIsFileExist(uploadedFile.Name));
            //fileStream.Close();
            //fileStream.Dispose();
        }
    }
}