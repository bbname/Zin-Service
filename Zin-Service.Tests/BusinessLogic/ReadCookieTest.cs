using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Configuration;
using Moq;
using NUnit.Framework;
using Zin_Service.BusinessLogic.Cookie.ReaderCookie;

namespace Zin_Service.Tests.BusinessLogic
{
    [TestFixture]
    public class ReadCookieTest
    {
        [Test]
        public void CheckIfCookieExist_StringIsNull_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = null;
            var context = new Mock<HttpContext>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.CheckIfCookieExist(context.Object,cookieName));
        }

        [Test]
        public void CheckIfCookieExist_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "";
            var context = new Mock<HttpContext>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.CheckIfCookieExist(context.Object, cookieName));
        }

        [Test]
        public void CheckIfCookieExist_StringIsUploadedFile_True()
        {
            // hanselman
            // http://www.hanselman.com/blog/ABackToBasicsCaseStudyImplementingHTTPFileUploadWithASPNETMVCIncludingTestsAndMocks.aspx

            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "UploadedFile";
            string cookieValue = "682f71e9-a217-43a2-8945-959548139124";
            bool expectedValue = true;
            var cookie = new Mock<HttpCookie>();
            var context = new Mock<HttpContext>();
            var request = new Mock<HttpRequest>();
            var cookies = new Mock<HttpCookieCollection>();
            var fakeCookies = new List<string>() { cookieName };
            context.Setup(ctx => ctx.Request).Returns(request.Object);
            request.Setup(req => req.Cookies).Returns(cookies.Object);
            cookies.Setup(c => c.GetEnumerator()).Returns(fakeCookies.GetEnumerator());
            cookies.Setup(c => c[cookieName]).Returns(cookie.Object);
            cookie.Setup(c => c.Name).Returns(cookieName);
            cookie.Setup(c => c.Value).Returns(cookieValue);

            // Act
            bool actualValue = readCookie.CheckIfCookieExist(context.Object, cookieName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}