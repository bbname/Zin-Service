using System;
using NUnit.Framework;
using Zin_Service.Service.Upload;

namespace Zin_Service.Tests.Service
{
    [TestFixture]
    public class ReadUploadedImageTest
    {
        [Test]
        public void CheckIsFileExist_StringIsNull_ExceptionThrown()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readUploadedImage.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readUploadedImage.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsowczarekpng_True()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = "owczarek.png";
            var expectedValue = true;

            // Act
            var actualValue = readUploadedImage.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CheckIsFileExist_StringIsowczarek123png_False()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = "owczarek123.png";
            var expectedValue = false;

            // Act
            var actualValue = readUploadedImage.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIsowczarekpng_ImagePng()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = "owczarek.png";
            var expectedValue = "image/png";

            // Act
            var actualValue = readUploadedImage.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIshistogramjpg_ImageJpeg()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileName = "histogram.jpg";
            var expectedValue = "image/jpeg";

            // Act
            var actualValue = readUploadedImage.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsNull_ExcpetionThrown()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileContentType = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readUploadedImage.CheckIsFileImageExtension(fileContentType));
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsEmpty_ExcpetionThrown()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileContentType = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readUploadedImage.CheckIsFileImageExtension(fileContentType));
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsTextPlain_ReturnFalse()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileContentType = "text/plain";
            var expectedResult = false;

            // Act 
            var actualResult = readUploadedImage.CheckIsFileImageExtension(fileContentType);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsImagePng_ReturnTrue()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileContentType = "image/png";
            var expectedResult = true;

            // Act
            var actualResult = readUploadedImage.CheckIsFileImageExtension(fileContentType);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsImageJpeg_ReturnTrue()
        {
            // Arrange
            var readUploadedImage = new ReadUploadedImage();
            string fileContentType = "image/jpeg";
            var expectedResult = true;

            // Act
            var actualResult = readUploadedImage.CheckIsFileImageExtension(fileContentType);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}