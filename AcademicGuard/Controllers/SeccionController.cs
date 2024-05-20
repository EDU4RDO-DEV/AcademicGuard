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
    public class SeccionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SeccionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Seccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seccion>>> GetSeccion()
        {
            return await _context.Seccion.ToListAsync();
        }

        // GET: api/Seccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seccion>> GetSeccion(int id)
        {
            var seccion = await _context.Seccion.FindAsync(id);

            if (seccion == null)
            {
                return NotFound();
            }

            return seccion;
        }

        // PUT: api/Seccion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeccion(int id, SeccionDto seccionDto)
        {
            if (id != seccionDto.Id_seccion)
            {
                return BadRequest();
            }

            var seccion = await _context.Seccion.FindAsync(id);
            if (seccion == null)
            {
                return NotFound();
            }

            seccion.Id_curso = seccionDto.Id_curso;
            seccion.Nombre = seccionDto.Nombre;
            seccion.Numero_semestre = seccionDto.Numero_semestre;
            seccion.Numero_estudiantes = seccionDto.Numero_estudiantes;
            seccion.Seccion_habilitada = seccionDto.Seccion_habilitada;
            seccion.Estado = seccionDto.Estado;

            _context.Entry(seccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeccionExists(id))
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

        // POST: api/Seccion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Seccion>> PostSeccion(SeccionDto seccionDto)
        {
            var seccion = new Seccion
            {
                Id_curso = seccionDto.Id_curso,
                Nombre = seccionDto.Nombre,
                Numero_semestre = seccionDto.Numero_semestre,
                Numero_estudiantes = seccionDto.Numero_estudiantes,
                Seccion_habilitada = seccionDto.Seccion_habilitada,
                Estado = seccionDto.Estado
            };

            _context.Seccion.Add(seccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeccion", new { id = seccion.Id_seccion }, seccion);
        }

        // DELETE: api/Seccion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeccion(int id)
        {
            var seccion = await _context.Seccion.FindAsync(id);
            if (seccion == null)
            {
                return NotFound();
            }

            _context.Seccion.Remove(seccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SeccionExists(int id)
        {
            return _context.Seccion.Any(e => e.Id_seccion == id);
        }
    }
}
