using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_usuario { get; set; }
        [ForeignKey("DetallePersona")]
        public int Id_detalle_persona { get; set; }
        public string Correo_institucional { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Ultima_conexion { get; set; }
        public string Estado { get; set; }

        [JsonIgnore] 
        public DetallePersona DetallePersona { get; set; }
    }
}
