using Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public class WriteGeneratedImageFileInfo : WriteImageFileInfo ,IWriteGeneratedImageFileInfo
    {
        private readonly IReadGeneratedImageFileInfo _readGeneratedImageFileInfo;
        public WriteGeneratedImageFileInfo(IReadGeneratedImageFileInfo readGeneratedImageFileInfo)
        {
            _readGeneratedImageFileInfo = readGeneratedImageFileInfo;
        }

        public void StoreGeneratedImage(byte[] image)
        {
            throw new System.NotImplementedException();
        }
    }
}