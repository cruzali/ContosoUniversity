using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    // Entidad student, en el contexto de base de datos.
    public class Student
    {
        public int ID { get; set; }
        [Required]        
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        // Si una propiedad de navegación puede contener varias entidades
        // entonces resulta en un listado y debe usar: 
        // ICollection, List o HashSet
        // Una propiedad de navegación contiene todas las entidades de relación
        // 
        public ICollection<Enrollment> Enrollments { get; set; }
        // ICollection crea un HashSet<T> de forma predeterminada

    }
}