﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AcademicGuard.Models
{
    public class Asistencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_asistencia { get; set; }
        [ForeignKey("Estudiante")]
        public int Id_estudiante { get; set; }
        [ForeignKey("Profesor")]
        public int Id_profesor { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public string Estado { get; set; }
        public string Asitencia { get; set; }
        public DateTime Fecha { get; set; }


        [JsonIgnore]
        public Estudiante Estudiante { get; set; }

        [JsonIgnore]
        public Profesor Profesor { get; set; }

        [JsonIgnore]
        public Coordinador Coordinador { get; set; }
    }
}