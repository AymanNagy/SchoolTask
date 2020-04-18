using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Database
{
    public class Schools
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolID { get; set; }

        [Required(ErrorMessage = "You Must Write School Name")]
        [Display(Name ="School Name")]
        public string SchoolName { get; set; }


        public ICollection<SchoolClass> SchoolClasss { get; set; }

    }
}
