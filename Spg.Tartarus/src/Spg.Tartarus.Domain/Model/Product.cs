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
        public int ShopId { get; set; }
        public int ReviewAmount { get; set; }
        public int CategoryId { get; set; }
        public IReadOnlyList<Shop> Shops => _shops;
        private List<Shop> _shops { get; set; } = new();
        public IReadOnlyList<Category> Categories => _categories;
        private List<Category> _categories { get; set; } = new();
        public IReadOnlyList<Review> Reviews => _reviews;
        private List<Review> _reviews { get; set; } = new(); // Backingfield

        //TODO Constructor

        protected Product()
        { }

        public Product(string name, string description, int shopId, int reviewAmount, int categoryId)
        {
            Name = name;
            Description = description;
            ShopId = shopId;
            ReviewAmount = reviewAmount;
            CategoryId = categoryId;
        }


        //TODO Backingfields
        //TODO was is mein primary key
    }
}
