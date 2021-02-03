using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Work_with_ImageFile_in_MVC.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=DBString")
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}