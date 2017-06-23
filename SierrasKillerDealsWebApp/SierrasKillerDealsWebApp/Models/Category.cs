using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierrasKillerDealsWebApp.Models
{
    class Category
    {
        public int CategoryID { get; set; }
        public string Clothing { get; set; }
        public string Jewelry { get; set; }
        public string Electronics { get; set; }
        public string Home { get; set; }
        public string Kitchen { get; set; }
        public string Health { get; set; }
        public string Food { get; set; }
        public string Pets { get; set; }
        public string Kids { get; set; }
        public string Maternity { get; set; }
        public string Freebies { get; set; }
        public string Sweeps { get; set; }

        public virtual ICollection<Deal> Deals { get; set; } // Many Deals belong to One Category
    }
}
