using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class SubjectTable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectTableID { get; set; }

        [ForeignKey(nameof(Day))]
        public int DayID { get; set; }
        public Days Day { get; set; }


        [ForeignKey(nameof(TeachersAndSubject))]
        public int TeachersAndSubjectID { get; set; }
        public TeachersAndSubject TeachersAndSubject { get; set; }


        [ForeignKey(nameof(SchoolClass))]
        public int SchoolClassID { get; set; }
        public SchoolClass SchoolClass { get; set; }



    }
}
