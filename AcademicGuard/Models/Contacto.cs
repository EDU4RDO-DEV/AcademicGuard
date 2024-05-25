using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_contacto { get; set; }
        [ForeignKey("DetallePersona")]
        public int Id_detalle_persona { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public string Telefono_casa { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public DetallePersona DetallePersona { get; set; }
    }
}
