using IDEducation.AuthServer.Models;
using IDEducation.AuthServer.Models.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IDEducation.AuthServer.Controllers
{
    
    using Mvc = System.Web.Mvc;
    using ROCRequest = OAuthROCRequest;
    using ROCRequestBinder = OAuthROCRequestBinder;

    [RoutePrefix("api/authorization")]
    public class AuthApiController : ApiController
    {
        [HttpPost]
        [Route("gettoken")]
        public IHttpActionResult GetToken(ROCRequest request)
        {
            return Ok(new
            {
                access_token = "2YotnFZFEjr1zCsicMWpAA",
                token_type = "json",
                expires_in = 3600,
                refresh_token = "tGzv3JOkF0XG5Qx2TlKWIA",
            });
        }
    }
}
