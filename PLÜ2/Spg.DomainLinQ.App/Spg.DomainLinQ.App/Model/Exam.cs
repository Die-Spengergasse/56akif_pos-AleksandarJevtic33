using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        // TODO: Implementation

        public DateTime? Date { get; private set; }
        public int? Lesson { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; private set; }
        public Subject SubjectNavigation { get; set; } = default!;
        public int Grade
        {
            get { return _note; }
            set
            {
                if(value >=1 && value <=5) {
                _note = value;
                }
            }
        }
        private int _note;

        protected Exam() { }

        public Exam(DateTime? date, int? lesson, DateTime created, Guid guid, int note, Subject subject)
        {
            Date = date;
            Lesson = lesson;
            Created = created;
            Guid = guid;
            Grade = note;
            SubjectNavigation = subject;
        }
    }
}
