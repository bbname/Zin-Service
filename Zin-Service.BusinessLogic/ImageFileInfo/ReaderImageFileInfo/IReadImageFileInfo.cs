using System.Collections;
using System.Collections.Generic;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public interface IReadImageFileInfo
    {
        bool CheckIsFileExist(string fileName);
        bool CheckIsFileEmpty(string fileName);
        List<string> ReadImageFileInfoBlock(string guid);

    }
}