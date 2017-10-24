using System;

namespace Zin_Service.Service.Generate
{
    public class GenerateImage : ImageFile, IGenerateImage
    {
        public override string Guid { get; set; }
        public override string Extension { get; set; }
        public override byte[] FileContent { get; set; }
        public DateTime GeneratedTime { get; set; }
    }
}