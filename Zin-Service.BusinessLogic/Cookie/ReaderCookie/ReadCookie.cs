using System;
using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public class ReadCookie : IReadCookie
    {
        public string GetCookieValue(HttpContext context, string cookieName)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfCookieExist(HttpContext context, string cookieName)
        {
            if (!String.IsNullOrEmpty(cookieName))
            {
                return context.Request.Cookies.Get(cookieName) != null ? true : false;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}