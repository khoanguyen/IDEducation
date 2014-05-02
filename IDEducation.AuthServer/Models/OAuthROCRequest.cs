using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer.Models
{
    
    public class OAuthROCRequest
    {
        public string GrantType { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Scope { get; set; }

    }
}