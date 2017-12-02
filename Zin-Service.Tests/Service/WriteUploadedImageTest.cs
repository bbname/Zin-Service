using System;
using System.IO;
using System.Web;
using Moq;
using NUnit.Framework;
using Zin_Service.Service.Upload;
using Zin_Service.Service.GeneratorImageName;

namespace Zin_Service.Tests.Service
{
    [TestFixture]
    public class WriteUploadedImageTest
    {
        [Test]
        public void ChangeFileName_StringIsNull_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
            string uploadedFileName = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImage.ChangeFileName(uploadedFileName));

        }

        [Test]
        public void ChangeFileName_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
            string uploadedFileName = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImage.ChangeFileName(uploadedFileName));

        }

        [Test]
        public void ChangeFileName_StringIsowczarekpng_ChangedFileName()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
            string uploadedFileName = "owczarek.png";

            // Act 
            writeUploadedImage.ChangeFileName(uploadedFileName);

            // Assert
            Assert.IsFalse(readUploadedImage.CheckIsFileExist(uploadedFileName));


        }

        [Test]
        public void StoreUploadedImage_FileIsNull_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => writeUploadedImage.StoreUploadedImage(null));
        }

        [Test]
        public void StoreUploadedImage_FileIsTxt_ExceptionThrown()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
            var path = @"E:\PROJEKTY\Zin-Service Images\Uploaded\jakistam.txt.txt";
            //var path = @"D:\Projekty\WŁASNE\Zin-Service Images\Uploaded\jakistam.txt.txt";
            var fileStream = new FileStream(path, FileMode.Open);
            var uploadedFile = new Mock<HttpPostedFileBase>();
            uploadedFile.Setup(f => f.FileName).Returns("jakistam.txt");
            uploadedFile.Setup(f => f.ContentType).Returns("text/plain");
            uploadedFile.Setup(f => f.InputStream).Returns(fileStream);
            uploadedFile.Setup(f => f.ContentLength).Returns(1000);

            // Act and Assert exception
            Assert.Throws<InvalidDataException>(() => writeUploadedImage.StoreUploadedImage(uploadedFile.Object));
            fileStream.Close();
            fileStream.Dispose();
        }

        [Test]
        public void StoreUploadedImage_FileIsPng_NotImplementedException()
        {
            // Arrange
            IReadUploadedImage readUploadedImage = new ReadUploadedImage();
            IGenerateImageName generateImageName = new GenerateImageName();
            var writeUploadedImage = new WriteUploadedImage(readUploadedImage, generateImageName);
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
            Assert.IsFalse(readUploadedImage.CheckIsFileExist(uploadedFile.Name));
            //fileStream.Close();
            //fileStream.Dispose();
        }
    }
}