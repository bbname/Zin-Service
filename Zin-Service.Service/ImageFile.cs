
namespace Zin_Service.Service
{
    public abstract class ImageFile
    {
        public abstract string Guid { get; set; }
        public abstract string Extension { get; set; }
        public abstract byte[] FileContent { get; set; }

    }
}