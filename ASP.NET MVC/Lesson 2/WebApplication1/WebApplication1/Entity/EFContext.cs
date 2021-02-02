using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=defaultString")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}

//Enable-migrations
//Add-migration "first"
//update-database
