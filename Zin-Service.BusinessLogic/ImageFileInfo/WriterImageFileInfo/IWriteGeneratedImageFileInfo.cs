using System;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteGeneratedImageFileInfo : IWriteImageFileInfo
    {
        void WriteLineGeneratedAndDateTime(DateTime generatedDateTime);
    }
}