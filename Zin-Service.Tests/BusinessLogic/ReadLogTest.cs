using System;
using NUnit.Framework;
using System.IO;
using Moq;
using Zin_Service.BusinessLogic.Logger.ReaderLog;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class ReadLogTest
    {
        [Test]
        public void IsFileLogExists_AreEqualExistsOrNotExists()
        {
            // Arrange
            IReadLog readLog = new ReadLog();

            var pathProjectTests = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var pathSolution = Directory.GetParent(pathProjectTests).Parent.FullName;
            var fullPathFileLog = pathSolution + "\\" + "Zin-Service.Service" + "\\Logs\\Log.txt";
            var expectedValue = File.Exists(fullPathFileLog);

            // Act
            var actualValue = readLog.IsFileLogExists();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void IsFileLogOpen_ExceptionThrown()
        {
            // Arrange
            IReadLog readLog = new ReadLog();

            // Act and assert exception
            Assert.Throws<>()
        }

        [Test]
        public void IsFileLogOpen_False()
        {
            // Arrange
            IReadLog readLog = new ReadLog();

            // Act
            var actualValue = readLog.IsFileLogOpen();

            // Assert
        }

        [Test]
        public void IsFileLogOpen_True()
        {
            // Arrange
            IReadLog readLog = new ReadLog();


            // Act

            // Assert
        }
    }
}