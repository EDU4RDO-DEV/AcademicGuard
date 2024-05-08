using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        //[JsonIgnore]
        //public Curso Curso { get; set; }
    }
}
