
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
    public class SubjectTableViewModel
    {

        public int ClassID { get; set; }
        public int DayID { get; set; }

        public int SchoolID { get; set; }
        public IEnumerable<School.Models.Database.TeachersAndSubject> ListOFTeactcherSubjects { get; set; }

        public IEnumerable<School.Models.Database.Days> ListOfDays { get; set; }


    }
}
