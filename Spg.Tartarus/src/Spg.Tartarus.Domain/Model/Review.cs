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
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Stars { get; set; }
        public User WrittenByUser { get; set; } = default!; //wie null 
        public DateTime FirstWritten { get; set; }
        public Status State { get; set; }



    }
}
