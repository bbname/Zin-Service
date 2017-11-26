using System.Drawing;
using Zin_Service.Service.WriterImage;

namespace Zin_Service.Service.Generate
{
    public class WriteGenerateImage : WriteImage, IWriteGenerateImage
    {
        public override void ChangeFileName(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void StoreGeneratedImage(Image image)
        {
            throw new System.NotImplementedException();
        }
    }
}