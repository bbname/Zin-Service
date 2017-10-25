using System;

namespace Zin_Service.Service.Generate
{
    public sealed class GenerateImage : ImageFile, IGenerateImage
    {

        public GenerateImage(string guid, string extension, byte[] fileContent, DateTime uploadedTime)
        {
            Guid = guid;
            Extension = extension;
            FileContent = fileContent;
            GeneratedTime = uploadedTime;
        }

        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime GeneratedTime { get; set; }
    }
}