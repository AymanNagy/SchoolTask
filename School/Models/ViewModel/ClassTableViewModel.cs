using School.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModel
{
    public class ClassTableViewModel
    {
        public IEnumerable<SubjectTable> ListOfSubSat { get; set; }
        public IEnumerable<SubjectTable> ListOfSubSun { get; set; }
        public IEnumerable<SubjectTable> ListOfSubMon { get; set; }
        public IEnumerable<SubjectTable> ListOfSubTue { get; set; }
        public IEnumerable<SubjectTable> ListOfSubThr { get; set; }
        public IEnumerable<SubjectTable> ListOfSubWed { get; set; }
        public IEnumerable<SubjectTable> ListOfSubFri { get; set; }
    }
}
