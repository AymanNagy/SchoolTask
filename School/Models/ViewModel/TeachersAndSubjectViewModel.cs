using School.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
    public class TeachersAndSubjectViewModel
    {
        public IEnumerable<Subjects> ListOfSubjects { get; set; }
        public int TeatcherID { get; set; }

        public int SubjectID { get; set; }
    }
}
