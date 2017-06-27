using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using SierrasKillerDealsWebApp.Models;

namespace SierrasKillerDealsWebApp.DAL
{
    public class PrototypeInitializer : System.Data.Entity.DropCreateDatabaseAlways<PrimaryContext>
    {
        protected override void Seed(PrimaryContext context)
        {
            var deals = new List<Deal>
            {
                new Deal{DealID=1, CategoryID=1, DealTitle="Black Vans", DealLink="", DealImage="", DealDescription="fdsfak ajg ajf ajfdjk gkfdljak"},
                new Deal{DealID=2, CategoryID=2, DealTitle="Baby Diapers", DealLink="", DealImage="", DealDescription="vjdfhs urva hbksifb iurb  sjf bisusi fjvs fj"},
            };
            deals.ForEach(s => context.Deals.Add(s));
            context.SaveChanges();
            //base.Seed(context);

            var categories = new List<Category>
            {
                new Category{CategoryID=1, CategoryTitle="Clothing" },
                new Category{CategoryID=2, CategoryTitle="Jewelry" },
                new Category{CategoryID=3, CategoryTitle="Electronics" },
                new Category{CategoryID=4, CategoryTitle="Home" },
                new Category{CategoryID=5, CategoryTitle="Kitchen" },
                new Category{CategoryID=6, CategoryTitle="Health" },
                new Category{CategoryID=7, CategoryTitle="Food" },
                new Category{CategoryID=8, CategoryTitle="Pets" },
                new Category{CategoryID=9, CategoryTitle="Kids" },
                new Category{CategoryID=10, CategoryTitle="Maternity" },
                new Category{CategoryID=11, CategoryTitle="Freebies" },
                new Category{CategoryID=12, CategoryTitle="Sweeps" },
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}
