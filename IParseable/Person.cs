using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParseable
{
    public class Person : IParsable<Person>
    {
       

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } =string.Empty;
        public DateTime BirthDate { get; set; }
        protected Person() // wird gesichert von außenzugriff geht auch mit private aber protected sicherer 
        { }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public static Person Parse(string s, IFormatProvider? provider)
        {
            if(s is null)
            {
                throw new ArgumentNullException("Input war NULL!");
            }
            string[] result = s.Split(new char[] { ',',';', '\t'}); ;
            if(result.Length != 3) 
            {
                throw new ArgumentException("Input muss bestehen aus FirstName, LastName, Birthdate");
            }
            DateTime birthDate;

            if (!DateTime.TryParse(result[2], out birthDate))
            {
                throw new FormatException("hat falsche format");
            }
            return new Person(result[0].Trim(), result[1].Trim(), birthDate);
        }

        public static bool TryParse([NotNullWhen(true)] string? s, 
            IFormatProvider? provider, 
            [MaybeNullWhen(false)] out Person result) 
            // ekige Klammer ist annotation wie @ java oder [] in c#
        {
            result = null;
            if (s is null)
            {
                return false;
            }

            try
            {
                result = Parse(s, provider);
                return true;
            }
            catch (Exception) // Exception vermeiden sondern mehrere Exception
            {
                return false;
            }
        }
    }
}
