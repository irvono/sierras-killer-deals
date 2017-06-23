using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SierrasKillerDealsWebApp.Models
{
    class Deal
    {
        public int DealID { get; set; }
        public int CategoryID { get; set; }
        public string DealTitle { get; set; }
        [DataType(DataType.Url)]
        public string DealLink { get; set; }
        [DataType(DataType.Url)]
        public string DealImage { get; set; } // this will be an image link that opens a new tab
        public string DealDescription { get; set; }

        public virtual Category Category { get; set; } // One category can have many deals
    }

    // This will be added to a DAL folder in a file called PrimaryContext.cs 
   // public class DealDBContext: DbContext
    //{
      //  public DbSet<Deal> Deals { get; set; }
    //}
}
