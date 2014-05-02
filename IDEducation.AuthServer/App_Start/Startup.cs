using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDEducation.AuthServer.Infrastructure.Middlewares;

[assembly: OwinStartup(typeof(IDEducation.AuthServer.Startup))]
namespace IDEducation.AuthServer
{   
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseFirstTimeUse();
        }
    }
}