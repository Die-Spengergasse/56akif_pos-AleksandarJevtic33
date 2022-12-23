using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        // TODO: Implementation
        public string Name { get; private set; } = string.Empty;
        public string Department => Name.Substring(0, 3);
        //    get {  return _department; } 
        //    set
        //    {
        //        _department= Name.Substring(0, 3);
        //    }
        //}
        //private string _department = string.Empty;
        public Guid Guid { get; private set; } 
        //public Subject SubjectNavigation { get; set; } = default!;
        public Teacher KV { get; set; } = default!;

        protected SchoolClass() { }

        public SchoolClass(string name, Teacher teacher, Guid guid)
        {
            
            Name = name;
            KV = teacher;
            Guid = guid;
        }
    }
}
