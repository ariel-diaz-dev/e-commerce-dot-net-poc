using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Common.Models
{
    public class Catalog
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
