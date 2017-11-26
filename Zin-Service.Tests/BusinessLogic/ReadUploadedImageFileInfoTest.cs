//using System;
//using System.Runtime.InteropServices;
//using NUnit.Framework;
//using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

//namespace Zin_Service.Tests.BusinessLogic
//{
//    [TestFixture]
//    public class ReadUploadedImageFileInfoTest
//    {
//        [Test]
//        public void CheckIsFileExist_StringIsNull_ExceptionThrown()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = null;

//            // Act and Assert exception
//            Assert.Throws<ArgumentNullException>(() => readUploadedImageFileInfo.CheckIsFileExist(fileName));
//        }

//        [Test]
//        public void CheckIsFileExist_StringIsEmpty_ExceptionThrown()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = "";

//            // Act and Assert exception
//            Assert.Throws<ArgumentNullException>(() => readUploadedImageFileInfo.CheckIsFileExist(fileName));
//        }

//        [Test]
//        public void CheckIsFileExist_StringIsowczarekpng_True()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = "owczarek.png";
//            var expectedValue = true;

//            // Act
//            var actualValue = readUploadedImageFileInfo.CheckIsFileExist(fileName);

//            // Assert
//            Assert.AreEqual(expectedValue, actualValue);
//        }

//        [Test]
//        public void CheckIsFileExist_StringIsowczarek123png_False()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = "owczarek123.png";
//            var expectedValue = false;

//            // Act
//            var actualValue = readUploadedImageFileInfo.CheckIsFileExist(fileName);

//            // Assert
//            Assert.AreEqual(expectedValue, actualValue);
//        }

//        [Test]
//        public void GetImageExtension_StringIsowczarekpng_ImagePng()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = "owczarek.png";
//            var expectedValue = "image/png";

//            // Act
//            var actualValue = readUploadedImageFileInfo.GetImageExtension(fileName);

//            // Assert
//            Assert.AreEqual(expectedValue, actualValue);
//        }

//        [Test]
//        public void GetImageExtension_StringIshistogramjpg_ImageJpeg()
//        {
//            // Arrange
//            var readUploadedImageFileInfo = new ReadUploadedImageFileInfo();
//            string fileName = "histogram.jpg";
//            var expectedValue = "image/jpeg";

//            // Act
//            var actualValue = readUploadedImageFileInfo.GetImageExtension(fileName);

//            // Assert
//            Assert.AreEqual(expectedValue, actualValue);
//        }
//    }
//}