using School.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
    public class ClassTableDailyViewModel
    {
        public IEnumerable<SchoolClass> ListOfClass { get; set; }
        public IEnumerable<SubjectTable> ListOfSubDay { get; set; }
      
    }
}
