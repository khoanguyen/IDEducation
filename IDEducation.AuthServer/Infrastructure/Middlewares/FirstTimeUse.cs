using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer.Infrastructure.Middlewares
{
    using Owin;
    using System.Configuration;
    using System.Diagnostics;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Mvc;
    using AppFunc = Func<IDictionary<string, object>, System.Threading.Tasks.Task>;

    public class FirstTimeUse
    {
        private readonly AppFunc _next;

        public FirstTimeUse(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var helper = new UrlHelper(HttpContext.Current.Request.RequestContext);

            if (ConfigurationManager.AppSettings["authServer:Configured"].Trim().ToLower() == "false" &&
                (!helper.RequestContext.RouteData.Values["controller"].Equals("ServerConfig") ||
                 !helper.RequestContext.RouteData.Values["action"].Equals("Index")))
            {
                var url = helper.Action("Index", "ServerConfig");
                HttpContext.Current.GetOwinContext().Response.Redirect(url);
            }
            else
            {
                await _next(environment);
            }
        }
    }

    public static class FirstTimeUseEx
    {
        public static void UseFirstTimeUse(this IAppBuilder appBuilder)
        {
            appBuilder.Use<FirstTimeUse>();
        }
    }
}