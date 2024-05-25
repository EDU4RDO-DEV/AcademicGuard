using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class CoordinadorDto
    {
      //  public int Id_coordinador { get; set; }
        public int Id_persona { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Fecha_contratacion { get; set; }
        public string Periodo_mandato { get; set; }
        public string Estado { get; set; }
    }
}
