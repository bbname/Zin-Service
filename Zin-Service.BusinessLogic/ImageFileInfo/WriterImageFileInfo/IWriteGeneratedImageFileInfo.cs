namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteGeneratedImageFileInfo : IWriteImageFileInfo
    {
        void StoreGeneratedImage(byte[] image);
    }
}