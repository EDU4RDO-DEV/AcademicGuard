using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class ProfesorDto
    {
        public int Id_profesor { get; set; }
        public int Id_persona { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Fecha_contratacion { get; set; }
        public string Estado { get; set; }
    }
}
