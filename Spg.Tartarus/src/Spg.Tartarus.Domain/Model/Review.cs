using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public enum Status { New, Old, Fake};
    public class Review
    {
        public int Id { get; private set;  }
        public string Title { get; set; } = string.Empty;
        public int Stars { get; set; }
        public User WrittenByUser { get; set; } = default!; //wie null 
        public Shop PostedShop { get; set; } = default!;
        public DateTime FirstWritten { get; set; }
        public Status State { get; set; }
        public Product RelatedProduct { get; set; } = default!;

        //TODO Constructor
        //TODO Backingfields

        protected Review()
        {

        }

        public Review(int id, string title, int stars, DateTime firstWritten, Status state)
        {
            Id = id;
            Title = title;
            Stars = stars;
            FirstWritten = firstWritten;
            State = state;
        }
    }
}
