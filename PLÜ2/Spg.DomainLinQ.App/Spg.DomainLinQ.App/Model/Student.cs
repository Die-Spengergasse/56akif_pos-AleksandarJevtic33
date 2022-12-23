using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        // TODO: Implementation
        public int RegistrationNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public PhoneNumber Phonenumber { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
        public Guid Guid { get; private set; } 
        public SchoolClass SchoolClass { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public string AccountName => LastName.Substring(0, 5) + RegistrationNumber;
        public virtual IReadOnlyList<Subject> Subjects => _subjects;

        private List<Subject> _subjects = new();
        protected Student() { }

        public Student(int registrationNumber, string firtsName, string lastName, string email, PhoneNumber phonenumber, 
            SchoolClass schoolClass,
            Address address,
            Gender genders, Guid guid)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firtsName;
            LastName = lastName;
            Email = email;
            Phonenumber = phonenumber;
            SchoolClass = schoolClass;
            Address = address;
            Gender = genders;
            Guid = guid;
        }

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
    }
}
