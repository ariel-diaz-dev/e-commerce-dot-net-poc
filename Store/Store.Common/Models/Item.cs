using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Common.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public Catalog Catalog { get; set; }
        public Guid CatalogId { get; set; }
    }
}
