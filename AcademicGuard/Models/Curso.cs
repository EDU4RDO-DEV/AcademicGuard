using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Curso
    {
        [Key]
        public int Id_curso { get ; set; }
        [ForeignKey("Profesor")]
        public int Id_profesor { get; set; }
        [ForeignKey("Estudiante")]
        public int Id_estudiante { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public string Nombre_curso { get; set; }
        public string Descripcion { get; set; }

        //public Profesor Profesor { get; set; }
        //public Estudiante Estudiante { get; set; }
        //public Coordinador Coordinador { get; set; }
    }
}
