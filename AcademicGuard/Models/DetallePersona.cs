using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class DetallePersona
    {
        [Key]
        public int Id_detalle_persona { get; set; }
        [ForeignKey("Persona")]
        public int Id_persona { get; set; }

        // Permite la relación de uno a uno con la tabla Persona (ForeignKey)
        public Persona Persona { get; set; }
    }
}
