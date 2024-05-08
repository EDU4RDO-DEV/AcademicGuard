using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Rol
    {
        [Key]
        public int Id_rol { get; set; }
        [ForeignKey("Usuario")]
        public int Id_usuario { get; set; }
        public string Tipo_rol { get; set; }

        //[JsonIgnore]
        //public Usuario Usuario { get; set; }
    }
}
