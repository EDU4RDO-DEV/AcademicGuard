using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class DetallePersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_detalle_persona { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public Persona Persona { get; set; }
    }
}
