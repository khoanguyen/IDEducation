using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDEducation.AuthServer.Infrastructure.Filters
{
    public class PreventFirstTimeConfig : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {            
            // Do nothing
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
}