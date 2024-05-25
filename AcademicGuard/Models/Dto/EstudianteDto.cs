using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class EstudianteDto
    {
       // public int Id_estudiante { get; set; }
        public int Id_persona { get; set; }
        public int Año_ingreso { get; set; }
        public string Estado { get; set; }
        public string Carne { get; set; }
    }
}
