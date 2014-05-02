using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDEducation.AuthServer.Models
{
    public partial class IDEAuthQueryContext
    {
        public override int SaveChanges()
        {
            throw new NotSupportedException("Query model does not allow INSERT/DELETE/UPDATE");
        }
    }
}