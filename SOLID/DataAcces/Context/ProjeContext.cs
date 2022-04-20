using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Context
{
 public   class ProjeContext:DbContext
    {
        public ProjeContext()
        {

            Database.Connection.ConnectionString = "server=.\\SQLEXPRESS;Database=UserDb;Trusted_Connection=true;";
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
    }
}
