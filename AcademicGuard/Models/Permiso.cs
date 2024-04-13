﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicGuard.Models
{
    public class Permiso
    {
        [Key]
        public int Id_permiso { get; set; }
        [ForeignKey("Estudiante")]
        public int Id_estudiante { get; set; }
        [ForeignKey("Profesor")]
        public int Id_profesor { get; set; }
        [ForeignKey("Coordinador")]
        public int Id_coordinador { get; set; }
        public string Motivo { get; set; }
        public string Documento_adjunto { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_solicitud { get; set; }
        public DateTime Fecha_respuesta { get; set; }

        public Estudiante Estudiante { get; set; }
        public Profesor Profesor { get; set; }
        public Coordinador Coordinador { get; set; }
    }
}