using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;

namespace IDEducation.AuthServer.Infrastructure.Factories
{
    public static class DIResolver
    {

        private static CompositionContainer _container;

        public static void SetContainer(CompositionContainer container)
        {
            _container = container;
        }

        public static void Inject(object target)
        {
            _container.SatisfyImportsOnce(target);
        }
    }
}