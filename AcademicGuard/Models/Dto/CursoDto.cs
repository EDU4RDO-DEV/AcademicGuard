using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class CursoDto
    {
        public int Id_curso { get; set; }
        public int Id_profesor { get; set; }
        public int Id_estudiante { get; set; }
        public int Id_coordinador { get; set; }
        public string Nombre_curso { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
