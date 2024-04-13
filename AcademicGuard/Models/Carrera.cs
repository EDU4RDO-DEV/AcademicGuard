using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Carrera
    {
        [Key]
        public int Id_carrera { get; set; }
        [ForeignKey("Curso")]
        public int Id_curso { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public bool Carrera_habilitada { get; set; }

        public Curso Curso { get; set; }
        public Coordinador Coordinador { get; set; }
    }
}
