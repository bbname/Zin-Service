using System;

namespace Zin_Service.BusinessLogic.CustomExceptions
{
    public class LogFileNotExistsException : Exception
    {
        public LogFileNotExistsException(string message)
            : base(message)
        {
            
        }
    }
}