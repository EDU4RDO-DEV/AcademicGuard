using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Seccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_seccion { get; set; }
        [ForeignKey("Curso")]
        public int Id_curso { get; set; }
        public string Nombre { get; set; }
        public string Numero_semestre { get; set; }
        public int Numero_estudiantes { get; set; }
        public string Seccion_habilitada { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public Curso Curso { get; set; }
    }
}
