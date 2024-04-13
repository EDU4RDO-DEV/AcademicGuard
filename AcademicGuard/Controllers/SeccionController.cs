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
        public async Task<IActionResult> PutSeccion(int id, Seccion seccion)
        {
            if (id != seccion.Id_seccion)
            {
                return BadRequest();
            }

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
        public async Task<ActionResult<Seccion>> PostSeccion(Seccion seccion)
        {
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
