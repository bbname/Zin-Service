using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public interface IReadCookie
    {
        string GetCookieValue(HttpContextBase httpContext, string cookieName);
        bool CheckIfCookieExist(HttpContextBase httpContext, string cookieName);
    }
}