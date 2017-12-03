using System;

namespace Zin_Service.BusinessLogic.CustomExceptions
{
    public class CookieNotExistsException : Exception
    {
        public CookieNotExistsException(string message) 
            : base (message)
        {
            
        }
    }
}