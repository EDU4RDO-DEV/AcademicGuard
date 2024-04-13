using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Usuario
    {
        [Key]
        public int Id_usuario { get; set; }
        [ForeignKey("DetallePersona")]
        public int Id_detalle_persona { get; set; }
        public string Correo_institucional { get; set; }
        public string Contraseña { get; set; }

        public DetallePersona DetallePersona { get; set; }
    }
}
