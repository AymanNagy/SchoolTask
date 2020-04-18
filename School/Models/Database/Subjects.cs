using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class Subjects
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectsID { get; set; }

        [Required(ErrorMessage = "You Must Write Subject Name")]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        public ICollection<TeachersAndSubject> TeachersAndSubjects { get; set; }

    }
}
