using System;

namespace Zin_Service.Service.Generate
{
    public interface IGenerateImage
    {
        string UploadedFileGuid { get; set; }
        DateTime GeneratedTime { get; set; }
    }
}