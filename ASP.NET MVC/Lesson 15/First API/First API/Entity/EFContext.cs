using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace First_API.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("defaultConnection")
        {

        }
        public DbSet<Bloger> Blogers { get; set; }
    }
}