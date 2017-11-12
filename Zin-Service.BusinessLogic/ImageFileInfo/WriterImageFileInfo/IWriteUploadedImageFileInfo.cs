using System.Web;

namespace Zin_Service.BusinessLogic.ImageFileInfo.WriterImageFileInfo
{
    public interface IWriteUploadedImageFileInfo : IWriteImageFileInfo
    {
        void StoreUploadedImage(HttpPostedFileBase file);
    }
}