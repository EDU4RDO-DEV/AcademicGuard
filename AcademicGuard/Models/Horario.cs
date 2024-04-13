using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Horario
    {
        [Key]
        public int Id_horario { get; set; }
        [ForeignKey("Curso")]
        public int Id_curso { get; set; }
        public string Dia { get; set; }
        public TimeSpan Hora_inicio { get; set; }
        public TimeSpan Hora_fin { get; set; }
        public bool Horario_habilitado { get; set; }

        public Curso Curso { get; set; }
    }
}
