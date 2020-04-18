using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class Days
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DayID { get; set; }

        [Required]
        [Display(Name = "Day Name")]
        public string DayName { get; set; }

        ICollection<SubjectTable> SubjectTables { get; set; }

    }
}
