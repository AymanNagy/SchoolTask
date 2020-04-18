using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class Teachers
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherID { get; set; }

        [Required(ErrorMessage = "You Must Write Teacher Name")]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        public ICollection<TeachersAndSubject> TeachersAndSubjects { get; set; }

    }
}
