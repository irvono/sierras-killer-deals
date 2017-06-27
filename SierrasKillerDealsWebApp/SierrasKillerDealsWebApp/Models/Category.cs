using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierrasKillerDealsWebApp.Models
{
   public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryTitle { get; set; }

        public virtual ICollection<Deal> Deals { get; set; } // Many Deals belong to One Category
    }
}
