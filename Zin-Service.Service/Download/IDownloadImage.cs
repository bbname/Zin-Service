using System;

namespace Zin_Service.Service.Download
{
    public interface IDownloadImage
    {
        DateTime DownloadedTime { get; set; }
    }
}