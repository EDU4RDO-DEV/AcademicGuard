using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Jornada
    {
        [Key]
        public int Id_jornada { get; set; }
        [ForeignKey("Curso")]
        public int Id_curso { get; set; }
        public string Tipo_jornada { get; set; }
        public bool Jornada_habilitada { get; set; }

        //public Curso Curso { get; set; }
    }
}
