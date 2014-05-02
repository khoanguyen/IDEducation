using IDEducation.AuthServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer
{
    public static class IoCStartup
    {
        public static void Configure()
        {
            var registration = new RegistrationBuilder();

            registration.ForType<IDEAuthQueryContext>()
                        .Export(eb => eb.AsContractName("AuthQueryContext"));

            using (var catalog = new AssemblyCatalog(typeof(IoCStartup).Assembly, registration))
            {
                var container = new CompositionContainer(catalog);
                
            }
        }
    }
}