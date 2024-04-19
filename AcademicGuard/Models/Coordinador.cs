using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Coordinador
    {
        [Key]
        public int Id_coordinador { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Fecha_contratacion { get; set; }
        public string Periodo_mandato { get; set; }

        [JsonIgnore]
        public Persona Persona { get; set; }
    }
}
