using IDEducation.AuthServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDEducation.AuthServer.Controllers
{
    
    public class ServerConfigController : Controller
    {
        // GET: ServerConfig
        public ActionResult Index()
        {
            return View(new FirstRunConfiguration());
        }
    }
}