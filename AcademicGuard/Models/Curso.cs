using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_curso { get ; set; }
        [ForeignKey("Profesor")]
        public int Id_profesor { get; set; }
        [ForeignKey("Estudiante")]
        public int Id_estudiante { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public string Nombre_curso { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public Profesor Profesor { get; set; }
        [JsonIgnore]
        public Estudiante Estudiante { get; set; }

        [JsonIgnore]
        public Coordinador Coordinador { get; set; }
    }
}
