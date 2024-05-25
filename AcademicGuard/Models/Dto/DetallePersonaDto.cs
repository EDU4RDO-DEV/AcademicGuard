using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class DetallePersonaDto
    {
        //public int Id_detalle_persona { get; set; }
        public int Id_persona { get; set; }
        public string Estado { get; set; }
    }
}
