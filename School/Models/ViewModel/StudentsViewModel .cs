using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
    public class StudentsViewModel
    {
        public int SchoolClassID { get; set; }
        public Models.Database.Students Students { get; set; }
        public IEnumerable<Models.Database.Students> ListOfStudents { get; set; }
        public IEnumerable<Models.Database.SchoolClass> ListOfSchoolClass { get; set; }
    }
}
