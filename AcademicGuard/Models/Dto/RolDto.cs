using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class RolDto
    {
        public int Id_rol { get; set; }
        public int Id_usuario { get; set; }
        public string Tipo_rol { get; set; }
        public string Estado { get; set; }
    }
}
