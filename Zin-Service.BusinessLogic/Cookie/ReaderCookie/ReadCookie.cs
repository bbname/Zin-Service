using System;
using System.Web;
using Zin_Service.BusinessLogic.CustomExceptions;

namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public class ReadCookie : IReadCookie
    {
        public string GetCookieValue(HttpContextBase context, string cookieName)
        {
            if (!String.IsNullOrEmpty(cookieName) || context != null)
            {
                try
                {
                    if (IsCookieExists(context, cookieName))
                    {
                        return context.Request.Cookies.Get(cookieName).Value;
                    }
                    else
                    {
                        throw new CookieNotExistsException("Unable to get cookie value, beacuse doesn't exists.");
                    }
                }
                catch (ArgumentNullException e)
                {
                    loggerHere
                    throw;
                }
                catch (Exception e)
                {
                    loggerHere
                    throw;
                }
            }
            else
            {
                throw new ArgumentNullException("Unable to get cookie value, context or cookieName was null or empty.");
            }
        }

        public bool IsCookieExists(HttpContextBase context, string cookieName)
        {
            if (!String.IsNullOrEmpty(cookieName) && context != null)
            {
                return context.Request.Cookies.Get(cookieName) != null ? true : false;
            }
            else
            {
                throw new ArgumentNullException("Unable to check is cookie exists, context or cookieName was null or empty.");
            }
        }
    }
}