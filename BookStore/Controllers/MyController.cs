using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Controllers
{
    public class MyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            //string ip = requestContext.HttpContext.Request.UserHostAddress;
            //var response = requestContext.HttpContext.Response;
            //response.Write("<h2>Ваш IP-адрес: " + ip + "</h2>");

            string browser = requestContext.HttpContext.Request.Browser.Browser;
            string user_agent = requestContext.HttpContext.Request.UserAgent;
            string url = requestContext.HttpContext.Request.RawUrl;
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            string referrer = requestContext.HttpContext.Request.UrlReferrer == null ? "" : requestContext.HttpContext.Request.UrlReferrer.AbsoluteUri;
            //return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
            //    "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
            var response = requestContext.HttpContext.Response;
            response.Write("<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>");
        }



    }
}