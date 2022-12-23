using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        // TODO: Implementation
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public Gender Gender { get; set; }
        public Guid Guid { get; private set; }
        
        public virtual IReadOnlyList<Subject> Subjects => _subjects;
        private List<Subject> _subjects = new();

        protected Teacher() { }

        public Teacher(string firstName, string lastName, string email, Address address, Gender gender, Guid guid)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Gender = gender;
            Guid = guid;
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
