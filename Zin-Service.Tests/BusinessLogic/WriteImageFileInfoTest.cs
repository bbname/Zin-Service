using Moq;
using NUnit.Framework;
using Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class WriteImageFileInfoTest
    {
        public void StoreImageFile_FileIsNull_ExceptionThrown()
        {
            // Arrange
            var writeImageFileInfo = new WriteImageFileInfo();
            writeImageFileInfo.StoreImageFile();

            // Act and Assert exception

        }
    }
}