using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Profesor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_profesor { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Fecha_contratacion { get; set; }

        public string Estado { get; set; }

        [JsonIgnore]
        public Persona Persona { get; set; }
    }
}
