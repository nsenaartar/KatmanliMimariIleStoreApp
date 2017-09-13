using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreConnectionString")
        {
            Database.SetInitializer(new StoreInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
