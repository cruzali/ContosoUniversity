using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        // Al no ser ICollection / List / HashSet, entonces es de null o uno solamente. No muchos.
        // No acepta null la propierad Instructor
        public Instructor Instructor { get; set; }
    }
}
