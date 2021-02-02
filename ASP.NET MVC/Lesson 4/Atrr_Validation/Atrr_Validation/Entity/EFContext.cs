using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Atrr_Validation.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=dbString")
        { }

        public DbSet<Games> Games { get; set; }
    }
}