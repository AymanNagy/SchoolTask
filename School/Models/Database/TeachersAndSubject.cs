using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class TeachersAndSubject
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeachersAndSubjectID { get; set; }

        [ForeignKey(nameof(teacher))]
        public int TeacherID { get; set; }
        [Required]
        [Display(Name = "Teatcher Name")]
        public Teachers teacher { get; set; }

        [ForeignKey(nameof(Subject))]
        public int SubjectsID { get; set; }
        [Required]
        [Display(Name = "Subject Name")]
        public Subjects Subject { get; set; }

        ICollection<SubjectTable> SubjectTables { get; set; }

    }
}
