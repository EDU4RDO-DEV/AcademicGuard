using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Seccion
    {
        [Key]
        public int Id_seccion { get; set; }
        [ForeignKey("Curso")]
        public int Id_curso { get; set; }
        public char Nombre { get; set; }
        public string Numero_semestre { get; set; }
        public int Numero_estudiantes { get; set; }
        public string Seccion_habilitada { get; set; }

        [JsonIgnore]
        public Curso Curso { get; set; }
    }
}
