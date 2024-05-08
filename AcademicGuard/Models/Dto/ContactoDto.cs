using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class ContactoDto
    {
        public int Id_contacto { get; set; }
        public int Id_detalle_persona { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public string Telefono_casa { get; set; }
        public string Estado { get; set; }
    }
}
