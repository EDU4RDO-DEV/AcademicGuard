using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models.Dto
{
    public class JornadaDto
    {
       // public int Id_jornada { get; set; }
        public int Id_curso { get; set; }
        public string Tipo_jornada { get; set; }
        public bool Jornada_habilitada { get; set; }
        public string Estado { get; set; }
    }
}
