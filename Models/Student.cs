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
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        // Si una propiedad de navegación puede contener varias entidades
        // entonces resulta en un listado y debe usar: 
        // ICollection, List o HashSet
        // Una propiedad de navegación contiene todas las entidades de relación
        // 
        public ICollection<Enrollment> Enrollments { get; set; }
        // ICollection crea un HashSet<T> de forma predeterminada

    }
}