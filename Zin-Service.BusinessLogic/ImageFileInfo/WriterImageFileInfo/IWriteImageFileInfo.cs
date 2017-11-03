using System;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteImageFileInfo
    {
        void WriteImageFileInfoBlock(DateTime dateTime, string fileName, string extension);
        void WriteLineGuidInfo(string guid);
        void WriteLineExtensionInfo(string extension);
        void WriteBlockSygnature(out string startBlock, out string endBlock);
    }
}