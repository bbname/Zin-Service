namespace Zin_Service.BusinessLogic.Logger.ReaderLog
{
    public interface IReadLog
    {
        bool IsFileLogExists();
        bool IsFileLogOpen();
    }
}