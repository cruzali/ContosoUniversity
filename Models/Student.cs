using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    // Entidad student, en el contexto de base de datos.
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
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