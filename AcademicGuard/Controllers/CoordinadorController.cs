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
    public class CoordinadorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CoordinadorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Coordinador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coordinador>>> GetCoordinador()
        {
            return await _context.Coordinador.ToListAsync();
        }

        // GET: api/Coordinador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coordinador>> GetCoordinador(int id)
        {
            var coordinador = await _context.Coordinador.FindAsync(id);

            if (coordinador == null)
            {
                return NotFound();
            }

            return coordinador;
        }

        // PUT: api/Coordinador/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoordinador(int id, Coordinador coordinador)
        {
            if (id != coordinador.Id_coordinador)
            {
                return BadRequest();
            }

            _context.Entry(coordinador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoordinadorExists(id))
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

        // POST: api/Coordinador
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Coordinador>> PostCoordinador(Coordinador coordinador)
        {
            _context.Coordinador.Add(coordinador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoordinador", new { id = coordinador.Id_coordinador }, coordinador);
        }

        // DELETE: api/Coordinador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoordinador(int id)
        {
            var coordinador = await _context.Coordinador.FindAsync(id);
            if (coordinador == null)
            {
                return NotFound();
            }

            _context.Coordinador.Remove(coordinador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CoordinadorExists(int id)
        {
            return _context.Coordinador.Any(e => e.Id_coordinador == id);
        }
    }
}
