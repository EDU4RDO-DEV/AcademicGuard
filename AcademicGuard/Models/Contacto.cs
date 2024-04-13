using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Contacto
    {
        [Key]
        public int Id_contacto { get; set; }
        [ForeignKey("DetallePersona")]
        public int Id_detalle_persona { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public string Telefono_casa { get; set; }

        public DetallePersona DetallePersona { get; set; }
    }
}
