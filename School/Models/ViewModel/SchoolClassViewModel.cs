using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
 


    public class SchoolClassViewModel
    {
        public int SchoolID { get; set; }

        public Models.Database.SchoolClass SchoolClass { get; set; }
        public IEnumerable<Models.Database.Schools> ListOfSchools { get; set; }

        public IEnumerable<Models.Database.SchoolClass> ListOfSchoolClass { get; set; }
    }
}
