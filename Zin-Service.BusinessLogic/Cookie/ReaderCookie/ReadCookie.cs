using System;
using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public class ReadCookie : IReadCookie
    {
        public string GetCookieValue(HttpContextBase context, string cookieName)
        {
            if (!String.IsNullOrEmpty(cookieName) || context != null)
            {
                if (CheckIfCookieExist(context, cookieName))
                {
                    return context.Request.Cookies.Get(cookieName).Value;
                }
                else
                {
                    throw new 
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public bool CheckIfCookieExist(HttpContextBase context, string cookieName)
        {
            if (!String.IsNullOrEmpty(cookieName) && context != null)
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