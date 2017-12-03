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
        public void IsCookieExists_StringIsNull_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = null;
            var context = new Mock<HttpContextBase>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.IsCookieExists(context.Object,cookieName));
        }

        [Test]
        public void IsCookieExists_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "";
            var context = new Mock<HttpContextBase>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.IsCookieExists(context.Object, cookieName));
        }

        [Test]
        public void IsCookieExists_ContextIsNull_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "randomCookieName";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.IsCookieExists(null, cookieName));
        }

        [Test]
        public void IsCookieExists_StringIsUploadedFile_True()
        {
            // hanselman
            // http://www.hanselman.com/blog/ABackToBasicsCaseStudyImplementingHTTPFileUploadWithASPNETMVCIncludingTestsAndMocks.aspx

            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "UploadedFile";
            string cookieValue = "682f71e9-a217-43a2-8945-959548139124";
            bool expectedValue = true;
            var cookie = new HttpCookie(cookieName, cookieValue);
            var context = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var cookies = new HttpCookieCollection {cookie};
            //cookies.Add(cookie);
            context.Setup(ctx => ctx.Request).Returns(request.Object);
            request.Setup(req => req.Cookies).Returns(cookies);

            // Act
            bool actualValue = readCookie.IsCookieExists(context.Object, cookieName);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void IsCookieExists_StringIsNotUploadedFile_False()
        {
            // hanselman
            // http://www.hanselman.com/blog/ABackToBasicsCaseStudyImplementingHTTPFileUploadWithASPNETMVCIncludingTestsAndMocks.aspx

            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieNameValid = "UploadedFile";
            string cookieNameInvalid = "NotUploadedFile";
            string cookieValue = "682f71e9-a217-43a2-8945-959548139124";
            bool expectedValue = false;
            var cookie = new HttpCookie(cookieNameValid, cookieValue);
            var context = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var cookies = new HttpCookieCollection {cookie};
            //cookies.Add(cookie);
            context.Setup(ctx => ctx.Request).Returns(request.Object);
            request.Setup(req => req.Cookies).Returns(cookies);

            // Act
            bool actualValue = readCookie.IsCookieExists(context.Object, cookieNameInvalid);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void GetCookieValue_StringIsNull_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = null;
            var context = new Mock<HttpContextBase>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.GetCookieValue(context.Object, cookieName));
        }

        [Test]
        public void GetCookieValue_StringIsEmpty_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "";
            var context = new Mock<HttpContextBase>();

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.GetCookieValue(context.Object, cookieName));
        }

        [Test]
        public void GetCookieValue_ContextIsNull_ExceptionThrown()
        {
            // Arrange
            IReadCookie readCookie = new ReadCookie();
            string cookieName = "randomCookieName";

            // Act and Assert exception
            Assert.Throws<ArgumentNullException>(() => readCookie.GetCookieValue(null, cookieName));
        }
    }
}