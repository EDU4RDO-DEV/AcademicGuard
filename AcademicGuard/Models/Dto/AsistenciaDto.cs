namespace AcademicGuard.Models.Dto
{
    public class AsistenciaDto
    {
        public int Id_asistencia { get; set; }
        public int Id_estudiante { get; set; }
        public int Id_profesor { get; set; }
        public int Id_coordinador { get; set; }
        public string Estado { get; set; }
        public string Asitencia { get; set; }
        public DateTime Fecha { get; set; }
    }
}
