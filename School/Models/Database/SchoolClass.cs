using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class SchoolClass
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolClassID { get; set; }

        [Required(ErrorMessage = "You Must Write Class Name")]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [ForeignKey(nameof(school))]
        public int SchoolID { get; set; }
        public Schools school { get; set; }

        ICollection<SubjectTable> SubjectTables { get; set; }
        public ICollection<Students> students { get; set; }


    }
}
