using System;
using NUnit.Framework;
using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class ReadGeneratedImageFileInfoTest
    {
        [Test]
        public void CheckIsFileExist_StringIsNull_ExceptionThrown()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readGeneratedImageFileInfo.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readGeneratedImageFileInfo.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsguidpng_True()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = "0d487941-689f-4560-b136-654af125d29f.png";
            var expectedValue = true;

            // Act
            var actualValue = readGeneratedImageFileInfo.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CheckIsFileExist_StringIsguidpng_False()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = "e2961ad2-c2ee-4c99-a12a-c75dab20ba5e.png";
            var expectedValue = false;

            // Act
            var actualValue = readGeneratedImageFileInfo.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIsGeneratedowczarekpng_ImagePng()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = "0d487941-689f-4560-b136-654af125d29f.png";
            var expectedValue = "image/png";

            // Act
            var actualValue = readGeneratedImageFileInfo.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIsGeneratedhistogramjpg_ImageJpeg()
        {
            // Arrange
            var readGeneratedImageFileInfo = new ReadGeneratedImageFileInfo();
            string fileName = "682f71e9-a217-43a2-8945-959548139124.jpg";
            var expectedValue = "image/jpeg";

            // Act
            var actualValue = readGeneratedImageFileInfo.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}