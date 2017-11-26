using System;
using NUnit.Framework;
using Zin_Service.Service.Generate;

namespace Zin_Service.Tests.Service
{
    [TestFixture]
    public class ReadGeneratedImageTest
    {
        [Test]
        public void CheckIsFileExist_StringIsNull_ExceptionThrown()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = null;

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readGeneratedImage.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = "";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readGeneratedImage.CheckIsFileExist(fileName));
        }

        [Test]
        public void CheckIsFileExist_StringIsguidpng_True()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = "0d487941-689f-4560-b136-654af125d29f.png";
            var expectedValue = true;

            // Act
            var actualValue = readGeneratedImage.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CheckIsFileExist_StringIsguidpng_False()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = "e2961ad2-c2ee-4c99-a12a-c75dab20ba5e.png";
            var expectedValue = false;

            // Act
            var actualValue = readGeneratedImage.CheckIsFileExist(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIsGeneratedowczarekpng_ImagePng()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = "0d487941-689f-4560-b136-654af125d29f.png";
            var expectedValue = "image/png";

            // Act
            var actualValue = readGeneratedImage.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetImageExtension_StringIsGeneratedhistogramjpg_ImageJpeg()
        {
            // Arrange
            var readGeneratedImage = new ReadGeneratedImage();
            string fileName = "682f71e9-a217-43a2-8945-959548139124.jpg";
            var expectedValue = "image/jpeg";

            // Act
            var actualValue = readGeneratedImage.GetImageExtension(fileName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}