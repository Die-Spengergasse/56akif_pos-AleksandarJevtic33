using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public enum Genders { Male, Female } //enumaration erstellt
    public class User
    {
        public int Id { get; set; }
        public Genders Gender { get; set; }
        public string FirtsName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty; 
        public DateTime BirthDate { get; set; } //= DateTime.MinValue; optional
        public DateTime RegistrationDateTime { get; set; }
        public List<Review> Reviews { get; set; } = new();
      

    }
}
