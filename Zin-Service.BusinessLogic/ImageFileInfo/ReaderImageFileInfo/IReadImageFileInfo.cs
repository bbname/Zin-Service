using System.Collections;
using System.Collections.Generic;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public interface IReadImageFileInfo
    {
        bool CheckIsFileExist(string fileName);
        bool CheckIsFileEmpty(string fileName);
        string GetImageExtension(string fileName);
        string GetFileName(string fileName);

    }
}