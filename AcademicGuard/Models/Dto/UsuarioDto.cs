using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class UsuarioDto
    {
        public int Id_usuario { get; set; }
        public int Id_detalle_persona { get; set; }
        public string Correo_institucional { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Ultima_conexion { get; set; }
        public string Estado { get; set; }
    }
}
