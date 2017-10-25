using System;

namespace Zin_Service.Service.Upload
{
    public sealed class UploadImage : ImageFile, IUploadImage
    {
        public UploadImage(string guid, string extension, byte[] fileContent, DateTime uploadedTime)
        {
            Guid = guid;
            Extension = extension;
            FileContent = fileContent;
            UploadedTime = uploadedTime;
        }

        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime UploadedTime { get; set; }
    }
}