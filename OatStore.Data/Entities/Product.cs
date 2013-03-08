using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OatStore.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
