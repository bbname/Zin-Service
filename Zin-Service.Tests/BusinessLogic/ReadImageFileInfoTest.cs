using System;
using NUnit.Framework;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class ReadImageFileInfoTest
    {
        [Test]
        public void CheckIsFileImageExtension_StringIsNull_ExcpetionThrown()
        {
            // Arrange
            var readImageFileInfo = new ReadImageFileInfo();
            string fileContentType = null;

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => readImageFileInfo.CheckIsFileImageExtension(fileContentType));
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsEmpty_ExcpetionThrown()
        {
            // Arrange
            var readImageFileInfo = new ReadImageFileInfo();
            string fileContentType = "";

            // Act and Assert exception
            Assert.Throws<NullReferenceException>(() => readImageFileInfo.CheckIsFileImageExtension(fileContentType));
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsTextPlain_ReturnFalse()
        {
            // Arrange
            var readImageFileInfo = new ReadImageFileInfo();
            string fileContentType = "text/plain";
            var expectedResult = false;

            // Act 
            var actualResult = readImageFileInfo.CheckIsFileImageExtension(fileContentType);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsImagePng_ReturnTrue()
        {
            // Arrange
            var readImageFileInfo = new ReadImageFileInfo();
            string fileContentType = "image/png";
            var expectedResult = true;

            // Act
            var actualResult = readImageFileInfo.CheckIsFileImageExtension(fileContentType);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIsFileImageExtension_StringIsImageJpeg_ReturnTrue()
        {
            // Arrange
            var readImageFileInfo = new ReadImageFileInfo();
            string fileContentType = "image/jpeg";
            var expectedResult = true;

            // Act
            var actualResult = readImageFileInfo.CheckIsFileImageExtension(fileContentType);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}