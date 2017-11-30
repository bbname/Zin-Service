using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public interface IReadCookie
    {
        string GetCookieValue(HttpContext httpContext, string cookieName);
        bool CheckIfCookieExist(HttpContext httpContext, string cookieName);
    }
}