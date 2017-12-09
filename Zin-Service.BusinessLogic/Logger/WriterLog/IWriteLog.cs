using System;

namespace Zin_Service.BusinessLogic.Logger.WriterLog
{
    public interface IWriteLog
    {
        void CreateLog(string message, Exception exception);
        void CreateFileLogger();
    }
}