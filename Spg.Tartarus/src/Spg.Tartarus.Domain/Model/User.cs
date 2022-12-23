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
        public int Id { get; private set; } // ReadOnly Datenbank vergibt ID
        public Genders Gender { get; set; }
        public string FirtsName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? EMail { get; set; } = string.Empty;
        public Address? Address { get; set; } = default!;
        public DateTime BirthDate { get; private set; } //= DateTime.MinValue; optional
        // Use Case fürs ändern des BirthDate
        public DateTime RegistrationDateTime { get; private set; }
        //public List<Review> Reviews { get; set; } = new(); //nicht mehr nötig weil liste aus review private
        private List<Review> _reviews = new();
        public virtual IReadOnlyList<Review> Reviews => _reviews;

        //TODO Constructor DONE
        //TODO Backingfields DONE

        protected User() // vererbung bleibt aber nicth nach außen nutzbar
        { }

        public User(int id, 
            Genders gender, 
            string firtsName, 
            string lastName, 
            string eMail, 
            DateTime birthDate, 
            DateTime registrationDateTime)
        {
            Id = id;
            Gender = gender;
            FirtsName = firtsName;
            LastName = lastName;
            EMail = eMail;
            BirthDate = birthDate;
            RegistrationDateTime = registrationDateTime;
            
            
        }
    }
}
