using System.Web;

namespace Zin_Service.BusinessLogic.Cookie.WriterCookie
{
    public class WriteCookie : IWriteCookie
    {
        public HttpCookie SetCookie(HttpContext httpContext, string cookieName, string cookieValue)
        {
            throw new System.NotImplementedException();
        }
    }
}