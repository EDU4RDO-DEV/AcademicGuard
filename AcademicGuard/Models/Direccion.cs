using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Direccion
    {
        [Key]
        public int Id_direccion { get; set; }
        [ForeignKey("DetallePersona")]
        public int Id_detalle_persona { get; set; }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Barrio { get; set; }
        public string Zona { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string Codigo_postal { get; set; }

        //[JsonIgnore]
        //public DetallePersona DetallePersona { get; set; }
    }
}
