using System;

namespace Zin_Service.Service.Upload
{
    public sealed class UploadImage : ImageFile, IUploadImage
    {
        public UploadImage(string guid, string uploadedFileName ,string extension, byte[] fileContent, DateTime uploadedTime)
        {
            UploadedFileName = uploadedFileName;
            Extension = extension;
            FileContent = fileContent;
            UploadedTime = uploadedTime;
            Guid = guid;
        }

        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public string UploadedFileName { get; set; }
        public DateTime UploadedTime { get; set; }
    }
}