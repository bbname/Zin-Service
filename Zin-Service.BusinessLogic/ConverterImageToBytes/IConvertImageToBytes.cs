using System.IO;

namespace Zin_Service.BusinessLogic.ConverterImageToBytes
{
    public interface IConvertImageToBytes
    {
        byte[] GetBytesFromFile(string fileGuid);
    }
}