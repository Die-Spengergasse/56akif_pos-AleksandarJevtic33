namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Street
    /// * Zip
    /// * City
    /// (2P)
    /// </summary>
    public class Address
    {
        // TODO: Implementation
        public string Street { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty; 

        protected Address()
        {

        }

        public Address(string street, string zip, string city)
        {
            Street = street;
            Zip = zip;
            City = city;
        }
    }
}
