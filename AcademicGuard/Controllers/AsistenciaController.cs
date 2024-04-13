using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcademicGuard.DataContext;
using AcademicGuard.Models;

namespace AcademicGuard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistenciaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AsistenciaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Asistencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistencia>>> GetAsistencia()
        {
            return await _context.Asistencia.ToListAsync();
        }

        // GET: api/Asistencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asistencia>> GetAsistencia(int id)
        {
            var asistencia = await _context.Asistencia.FindAsync(id);

            if (asistencia == null)
            {
                return NotFound();
            }

            return asistencia;
        }

        // PUT: api/Asistencia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencia(int id, Asistencia asistencia)
        {
            if (id != asistencia.Id_asistencia)
            {
                return BadRequest();
            }

            _context.Entry(asistencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsistenciaExists(id))
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

        // POST: api/Asistencia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Asistencia>> PostAsistencia(Asistencia asistencia)
        {
            _context.Asistencia.Add(asistencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsistencia", new { id = asistencia.Id_asistencia }, asistencia);
        }

        // DELETE: api/Asistencia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsistencia(int id)
        {
            var asistencia = await _context.Asistencia.FindAsync(id);
            if (asistencia == null)
            {
                return NotFound();
            }

            _context.Asistencia.Remove(asistencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsistenciaExists(int id)
        {
            return _context.Asistencia.Any(e => e.Id_asistencia == id);
        }
    }
}
