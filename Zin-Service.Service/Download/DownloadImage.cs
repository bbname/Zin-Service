using System;

namespace Zin_Service.Service.Download
{
    public class DownloadImage : ImageFile, IDownloadImage
    {
        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime DownloadedTime { get; set; }
    }
}