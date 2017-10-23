using System;

namespace Zin_Service.Service.Upload
{
    public class UploadImage : ImageFile, IUploadImage
    {
        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime UploadedTime { get; set; }
    }
}