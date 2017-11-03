using System;

namespace Zin_Service.Service.Generate
{
    public sealed class GenerateImage : ImageFile, IGenerateImage
    {

        public GenerateImage(string guid, string uploadedFileGuid, string extension, byte[] fileContent, DateTime uploadedTime)
        {
            UploadedFileGuid = uploadedFileGuid;
            Extension = extension;
            FileContent = fileContent;
            GeneratedTime = uploadedTime;
            Guid = guid;
        }

        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public string UploadedFileGuid { get; set; }
        public DateTime GeneratedTime { get; set; }
    }
}