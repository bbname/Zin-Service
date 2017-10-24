using System;
using System.CodeDom;

namespace Zin_Service.Service.Upload
{
    public class UploadImage : ImageFile, IUploadImage
    {
        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime UploadedTime { get; set; }

        public UploadImage(string guid, string extension, byte[] fileContent, DateTime uploadedTime)
        {
            Guid = guid;
            Extension = extension;
            FileContent = fileContent;
            UploadedTime = uploadedTime;
        }
    }
}