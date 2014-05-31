using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.DataAccess.Context
{
    public class TFContext : DbContext
    {
        public DbSet<Award> Award { get; set; }
        public DbSet<Contact> Contact { get; set; }

        
    }
}