using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Zin_Service.BusinessLogic.ImageFileInfo.ReaderImageFileInfo
{
    public interface IReadImageFileInfo
    {
        bool CheckIsFileExist(string fileName);
        bool CheckIsFileImageExtension(string fileContentType);
        string GetImageExtension(string fileName);
        string GetFileName(string fullFileName);

    }
}