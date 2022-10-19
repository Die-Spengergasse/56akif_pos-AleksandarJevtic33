using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Shop> Shops { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
    }
}
