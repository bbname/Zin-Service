namespace Zin_Service.BusinessLogic.Logger.WriterLog
{
    public interface IWriteLog
    {
        void CreateLog(string message);
        void CreateFileLogger();
    }
}