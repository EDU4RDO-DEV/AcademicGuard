using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcademicGuard.DataContext;
using AcademicGuard.Models;
using AcademicGuard.Models.Dto;

namespace AcademicGuard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

        // GET: api/Persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return persona;
        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersona(int id, PersonaDto personaDto)
        {
            if (id != personaDto.Id_persona)
            {
                return BadRequest();
            }

            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            persona.Dpi = personaDto.Dpi;
            persona.Primer_nombre = personaDto.Primer_nombre;
            persona.Segundo_nombre = personaDto.Segundo_nombre;
            persona.Nombres_extras = personaDto.Nombres_extras;
            persona.Primer_apellido = personaDto.Primer_apellido;
            persona.Segundo_apellido = personaDto.Segundo_apellido;
            persona.Apellidos_extras = personaDto.Apellidos_extras;
            persona.Sexo = personaDto.Sexo;
            persona.Fecha_nacimiento = personaDto.Fecha_nacimiento;
            persona.Persona_habilitada = personaDto.Persona_habilitada;
            persona.Fecha_creacion = personaDto.Fecha_creacion;
            persona.Fecha_modificacion = personaDto.Fecha_modificacion;
            persona.Usuario_modificacion = personaDto.Usuario_modificacion;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Persona
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(PersonaDto personaDto)
        {
            var persona = new Persona
            {
                Dpi = personaDto.Dpi,
                Primer_nombre = personaDto.Primer_nombre,
                Segundo_nombre = personaDto.Segundo_nombre,
                Nombres_extras = personaDto.Nombres_extras,
                Primer_apellido = personaDto.Primer_apellido,
                Segundo_apellido = personaDto.Segundo_apellido,
                Apellidos_extras = personaDto.Apellidos_extras,
                Sexo = personaDto.Sexo,
                Fecha_nacimiento = personaDto.Fecha_nacimiento,
                Persona_habilitada = personaDto.Persona_habilitada,
                Fecha_creacion = personaDto.Fecha_creacion,
                Fecha_modificacion = personaDto.Fecha_modificacion,
                Usuario_modificacion = personaDto.Usuario_modificacion
            };

            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.Id_persona }, persona);
        }

        // DELETE: api/Persona/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.Id_persona == id);
        }
    }
}
