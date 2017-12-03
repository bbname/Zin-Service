namespace Zin_Service.BusinessLogic.Logger.ReaderLog
{
    public interface IReadLog
    {
        bool IsFileLogExist();
        bool IsFileLogOpen();
    }
}