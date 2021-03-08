using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers.SecureCookie
{
    public class SecureCookieTest1: ControllerBase
    {
        [HttpGet("response")]
        [HttpGet("{request}")]

        // HttpCookie myCookie = new HttpCookie("Sensitive cookie");

        public void Unsafe(HttpResponse response, HttpRequest request)
        {
            var options = new CookieOptions();
            options.Path = "/";
            options.Domain = "";
            var password = "p-12345678";// + RandomNumberGenerator.GetInt32(200000000, 2000000000);
            response.Cookies.Append("password", password, options);
        }
    }
}