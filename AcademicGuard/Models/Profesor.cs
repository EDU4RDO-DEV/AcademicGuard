using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Profesor
    {
        [Key]
        public int Id_profesor { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Fecha_contratacion { get; set; }

        //public Persona Persona { get; set; }
    }
}
