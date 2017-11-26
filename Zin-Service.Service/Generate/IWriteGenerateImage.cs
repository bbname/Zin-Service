using System.Drawing;
using Zin_Service.Service.WriterImage;

namespace Zin_Service.Service.Generate
{
    public interface IWriteGenerateImage : IWriteImage
    {
        void StoreGeneratedImage(Image image);
    }
}