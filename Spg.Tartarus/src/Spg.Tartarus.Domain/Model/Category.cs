using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public  class Category
    {
        public int Id { get; private set;  }
        public string Name { get; set; } =string.Empty;
        //public int ProductId { get; set; }
        public virtual IReadOnlyList<Product> Products => _products;
        private List<Product> _products = new();

        //TODO Constructor

        protected Category()
        {

        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //TODO Backingfields

    }
}
