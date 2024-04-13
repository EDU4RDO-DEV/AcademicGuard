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
    public class DetallePersonaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DetallePersonaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DetallePersona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallePersona>>> GetDetallePersona()
        {
            return await _context.DetallePersona.ToListAsync();
        }

        // GET: api/DetallePersona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetallePersona>> GetDetallePersona(int id)
        {
            var detallePersona = await _context.DetallePersona.FindAsync(id);

            if (detallePersona == null)
            {
                return NotFound();
            }

            return detallePersona;
        }

        // PUT: api/DetallePersona/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetallePersona(int id, DetallePersona detallePersona)
        {
            if (id != detallePersona.Id_detalle_persona)
            {
                return BadRequest();
            }

            _context.Entry(detallePersona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetallePersonaExists(id))
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

        // POST: api/DetallePersona
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetallePersona>> PostDetallePersona(DetallePersona detallePersona)
        {
            _context.DetallePersona.Add(detallePersona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetallePersona", new { id = detallePersona.Id_detalle_persona }, detallePersona);
        }

        // DELETE: api/DetallePersona/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetallePersona(int id)
        {
            var detallePersona = await _context.DetallePersona.FindAsync(id);
            if (detallePersona == null)
            {
                return NotFound();
            }

            _context.DetallePersona.Remove(detallePersona);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetallePersonaExists(int id)
        {
            return _context.DetallePersona.Any(e => e.Id_detalle_persona == id);
        }
    }
}
