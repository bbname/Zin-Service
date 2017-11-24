namespace Zin_Service.Service.Upload
{
    public interface IReadUploadedImage
    {
        bool CheckIsFileExist(string fileName);
        string GetImageExtension(string fileName);
        byte[] GetImage(string fileName);
    }
}