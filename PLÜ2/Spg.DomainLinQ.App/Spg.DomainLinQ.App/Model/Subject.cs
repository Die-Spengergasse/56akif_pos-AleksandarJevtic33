using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {
        // TODO: Implementation
        public string Description { get; set; } = string.Empty;
        public SchoolClass SchoolClassNavigation { get; set; } = default!;
        //public Teacher TeacherNavigation { get; set; } = default!;
        //public Student StudentNavigation { get; set; } = default!;

        protected Subject() { }

        public Subject(string description, SchoolClass schoolClass)
        {
            Description = description;
            SchoolClassNavigation = schoolClass;

            //Description = description;
        }
    }
}
