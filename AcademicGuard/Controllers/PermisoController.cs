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
    public class PermisoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PermisoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Permiso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Permiso>>> GetPermiso()
        {
            return await _context.Permiso.ToListAsync();
        }

        // GET: api/Permiso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Permiso>> GetPermiso(int id)
        {
            var permiso = await _context.Permiso.FindAsync(id);

            if (permiso == null)
            {
                return NotFound();
            }

            return permiso;
        }

        // PUT: api/Permiso/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermiso(int id, Permiso permiso)
        {
            if (id != permiso.Id_permiso)
            {
                return BadRequest();
            }

            _context.Entry(permiso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermisoExists(id))
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

        // POST: api/Permiso
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Permiso>> PostPermiso(Permiso permiso)
        {
            _context.Permiso.Add(permiso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPermiso", new { id = permiso.Id_permiso }, permiso);
        }

        // DELETE: api/Permiso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePermiso(int id)
        {
            var permiso = await _context.Permiso.FindAsync(id);
            if (permiso == null)
            {
                return NotFound();
            }

            _context.Permiso.Remove(permiso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PermisoExists(int id)
        {
            return _context.Permiso.Any(e => e.Id_permiso == id);
        }
    }
}
