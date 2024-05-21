using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class SeccionDto
    {
      //  public int Id_seccion { get; set; }
        public int Id_curso { get; set; }
        public string Nombre { get; set; }
        public string Numero_semestre { get; set; }
        public int Numero_estudiantes { get; set; }
        public string Seccion_habilitada { get; set; }
        public string Estado { get; set; }
    }
}
