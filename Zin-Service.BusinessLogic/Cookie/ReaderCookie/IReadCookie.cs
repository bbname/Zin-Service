namespace Zin_Service.BusinessLogic.Cookie.ReaderCookie
{
    public interface IReadCookie
    {
        string GetCookieName();
        string GetCookieValue();
        bool CheckIfCookieExist();
    }
}