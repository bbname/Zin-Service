namespace Zin_Service.BusinessLogic.Cookie.WriterCookie
{
    public interface IWriteCookie
    {
        void WriteCookieName(string cookieName);
        void WriteCookieValue(string cookieValue);
        void WriteCookieExpirationDate();
    }
}