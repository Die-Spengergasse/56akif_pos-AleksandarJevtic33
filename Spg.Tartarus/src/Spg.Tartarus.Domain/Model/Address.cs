using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Tartarus.Domain.Model
{
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;

        protected Address()
        {

        }

        public Address(string street, string houseNumber, string city, string zip)
        {
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            Zip = zip;
        }
    }

   
}
