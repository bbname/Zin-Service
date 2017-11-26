using System;

namespace Zin_Service.Service.WriterImage
{
    public abstract class WriteImage : IWriteImage
    {
        public abstract void ChangeFileName(string fileName);
    }
}