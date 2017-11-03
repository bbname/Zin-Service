using System;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteUploadedImageFileInfo : IWriteImageFileInfo
    {
        void WriteLineUploadedAndDateTime(DateTime generatedDateTime);
    }
}