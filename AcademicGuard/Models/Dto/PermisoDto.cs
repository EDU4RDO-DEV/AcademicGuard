using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class PermisoDto
    {
      //  public int Id_permiso { get; set; }
        public int Id_estudiante { get; set; }
        public int Id_profesor { get; set; }
        public int Id_coordinador { get; set; }
        public string Motivo { get; set; }
        public string Documento_adjunto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_solicitud { get; set; }
        public DateTime Fecha_respuesta { get; set; }
        public string Estado { get; set; }
        public bool Estado_aceptacion { get; set; }
    }
}
