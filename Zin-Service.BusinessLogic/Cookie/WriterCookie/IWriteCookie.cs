using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.WriterCookie
{
    public interface IWriteCookie
    {
        HttpCookie SetCookie(HttpContext httpContext, string cookieName, string cookieValue);
    }
}