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
    public class ProfesorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProfesorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Profesor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesor>>> GetProfesor()
        {
            return await _context.Profesor.ToListAsync();
        }

        // GET: api/Profesor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetProfesor(int id)
        {
            var profesor = await _context.Profesor.FindAsync(id);

            if (profesor == null)
            {
                return NotFound();
            }

            return profesor;
        }

        // PUT: api/Profesor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesor(int id, Profesor profesor)
        {
            if (id != profesor.Id_profesor)
            {
                return BadRequest();
            }

            _context.Entry(profesor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesorExists(id))
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

        // POST: api/Profesor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Profesor>> PostProfesor(Profesor profesor)
        {
            _context.Profesor.Add(profesor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesor", new { id = profesor.Id_profesor }, profesor);
        }

        // DELETE: api/Profesor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var profesor = await _context.Profesor.FindAsync(id);
            if (profesor == null)
            {
                return NotFound();
            }

            _context.Profesor.Remove(profesor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfesorExists(int id)
        {
            return _context.Profesor.Any(e => e.Id_profesor == id);
        }
    }
}
