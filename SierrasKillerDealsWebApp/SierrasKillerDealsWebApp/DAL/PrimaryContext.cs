using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using SierrasKillerDealsWebApp.Models;

namespace SierrasKillerDealsWebApp.DAL
{
   public class PrimaryContext : DbContext 
    {
        public PrimaryContext() : base("PrimaryContext")
        { }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }


}
