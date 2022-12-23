using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExColection.App
{
    public abstract class Person
    {
        public abstract string GetArriveType
        {
            get; 
        }

        public string ArrivesAtSchoolWith()
        {
            return "Kommt mit Auto";
        }

        public virtual int KatzenAnzahl()
        {
            return 1;
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"Full Name: {FirstName} {LastName}";
            }
        }

    }
}
