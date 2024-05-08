using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class HorarioDto
    {
        public int Id_horario { get; set; }
        public int Id_curso { get; set; }
        public string Dia { get; set; }
        public TimeSpan Hora_inicio { get; set; }
        public TimeSpan Hora_fin { get; set; }
        public bool Horario_habilitado { get; set; }
        public string Estado { get; set; }
    }
}
