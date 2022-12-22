using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public class Product
    {
        public string Name { get; private set;  } =string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public int ReviewAmount { get; set; }
        public virtual Category CategoryNavigation { get; private set; } = default!;
        public virtual IReadOnlyList<Shop> Shops => _shops;
        private List<Shop> _shops { get; set; } = new();
        //public virtual IReadOnlyList<Category> Categories => _categories;
        //private List<Category> _categories { get; set; } = new();
        public virtual IReadOnlyList<Review> Reviews => _reviews;
        private List<Review> _reviews { get; set; } = new(); // Backingfield

        //TODO Constructor

        protected Product()
        { }

        public Product(string name, string description, int reviewAmount, Category category)
        {
            Name = name;
            Description = description;
            ReviewAmount = reviewAmount;
            CategoryNavigation = category;
        }


        //TODO Backingfields
        //TODO was is mein primary key
    }
}
