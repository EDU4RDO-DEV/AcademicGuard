using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class CarreraDto
    {
        public int Id_carrera { get; set; }
        public int Id_curso { get; set; }
        public int Id_coordinador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public bool Carrera_habilitada { get; set; }
        public string Estado { get; set; }
    }
}
