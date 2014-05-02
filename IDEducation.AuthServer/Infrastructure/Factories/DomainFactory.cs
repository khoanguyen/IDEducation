using IDEducation.AuthServer.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer.Infrastructure.Factories
{
    public static class DomainFactory
    {
        
        public static TLogic Get<TLogic>()
        {
            return default(TLogic);
        }
    }
}