using System;

namespace Zin_Service.Service.Upload
{
    public interface IUploadImage
    {
        string UploadedFileName { get; set; }
        DateTime UploadedTime { get; set; }
    }
}