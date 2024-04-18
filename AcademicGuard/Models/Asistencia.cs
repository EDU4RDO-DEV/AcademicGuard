using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Asistencia
    {
        [Key]
        public int Id_asistencia { get; set; }
        [ForeignKey("Estudiante")]
        public int Id_estudiante { get; set; }
        [ForeignKey("Profesor")]
        public int Id_profesor { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public char Estado { get; set; }

        //public Estudiante Estudiante { get; set; }
        //public Profesor Profesor { get; set; }
        //public Coordinador Coordinador { get; set; }
    }
}