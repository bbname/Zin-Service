using System;

namespace Zin_Service.Service.Generate
{
    public sealed class GenerateImage: IGenerateImage
    {
        public string UploadedFileGuid { get; set; }
        public DateTime GeneratedTime { get; set; }
    }
}