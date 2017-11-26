using NUnit.Framework;
using Zin_Service.Service.GeneratorImageName;

namespace Zin_Service.Tests.Service
{
    [TestFixture]
    public class GenerateImageNameTest
    {
        [Test]
        public void GenerateName_GenerateRandomString_String()
        {
            // Arrange
            var generateImageName = new GenerateImageName();

            // Act
            var randomGuid = generateImageName.GenerateName();

            // Assert
            Assert.IsNotEmpty(randomGuid);
        }
    }
}