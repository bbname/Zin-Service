namespace Zin_Service.Service.ReaderImage
{
    public interface IReadImage
    {
        bool CheckIsFileExist(string fileName);
        bool CheckIsFileImageExtension(string fileContentType);
        string GetImageExtension(string fileName);
        byte[] GetImage(string fileName);
    }
}