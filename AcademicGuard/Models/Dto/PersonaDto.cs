namespace AcademicGuard.Models.Dto
{
    public class PersonaDto
    {
        //public int Id_persona { get; set; }
        public string Dpi { get; set; }
        public string Primer_nombre { get; set; }
        public string Segundo_nombre { get; set; }
        public string Nombres_extras { get; set; }
        public string Primer_apellido { get; set; }
        public string Segundo_apellido { get; set; }
        public string Apellidos_extras { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public bool Persona_habilitada { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Fecha_modificacion { get; set; }
        public string Usuario_modificacion { get; set; }
        public string Estado { get; set; }
        //public int IdPersona { get; internal set; }
        //public string PrimerNombre { get; internal set; }
    }
}
