using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_estudiante { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }
        public int Año_ingreso { get; set; }
        public string Estado { get; set; }
        public string Carne { get; set; } 


        [JsonIgnore]
        public Persona Persona { get; set; }
    }
}
