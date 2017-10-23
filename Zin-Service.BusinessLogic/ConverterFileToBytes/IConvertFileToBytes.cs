using System.IO;

namespace Zin_Service.BusinessLogic.ConverterFileToBytes
{
    public interface IConvertFileToBytes
    {
        byte[] GetBytesFromFile(string fileGuid);
    }
}