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
    public class EstudianteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstudianteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Estudiante
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiante()
        {
            return await _context.Estudiante.ToListAsync();
        }

        // GET: api/Estudiante/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetEstudiante(int id)
        {
            var estudiante = await _context.Estudiante.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }

            return estudiante;
        }

        // PUT: api/Estudiante/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudiante(int id, EstudianteDto estudianteDto)
        {
            //if (id != estudianteDto.Id_estudiante)
            //{
            //    return BadRequest();
            //}

            var estudiante = await _context.Estudiante.FindAsync(id);
            if (estudiante == null)
            {
                return NotFound();
            }

            estudiante.Id_persona = estudianteDto.Id_persona;
            estudiante.Año_ingreso = estudianteDto.Año_ingreso;
            estudiante.Estado = estudianteDto.Estado;

            _context.Entry(estudiante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteExists(id))
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

        // POST: api/Estudiante
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estudiante>> PostEstudiante(EstudianteDto estudianteDto)
        {
            var estudiante = new Estudiante
            {
                Id_persona = estudianteDto.Id_persona,
                Año_ingreso = estudianteDto.Año_ingreso,
                Estado = estudianteDto.Estado
            };

            _context.Estudiante.Add(estudiante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstudiante", new { id = estudiante.Id_estudiante }, estudiante);
        }

        // DELETE: api/Estudiante/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudiante(int id)
        {
            var estudiante = await _context.Estudiante.FindAsync(id);
            if (estudiante == null)
            {
                return NotFound();
            }

            _context.Estudiante.Remove(estudiante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudianteExists(int id)
        {
            return _context.Estudiante.Any(e => e.Id_estudiante == id);
        }
    }
}
