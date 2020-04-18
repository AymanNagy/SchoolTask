using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class Students
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "You Must Write Student Name")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [ForeignKey(nameof(SchoolClass))]
        public int SchoolClassID { get; set; }
        public SchoolClass SchoolClass { get; set; }
    }
}
