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
using Microsoft.AspNetCore.Authorization;

namespace AcademicGuard.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRol()
        {
            return await _context.Rol.ToListAsync();
        }

        // GET: api/Rol/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
            var rol = await _context.Rol.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        // PUT: api/Rol/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol(int id, RolDto rolDto)
        {
            //if (id != rolDto.Id_rol)
            //{
            //    return BadRequest();
            //}

            var rol = await _context.Rol.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            rol.Id_usuario = rolDto.Id_usuario;
            rol.Tipo_rol = rolDto.Tipo_rol;
            rol.Estado = rolDto.Estado;

            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(id))
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

        // POST: api/Rol
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rol>> PostRol(RolDto rolDto)
        {
            var rol = new Rol
            {
                Id_usuario = rolDto.Id_usuario,
                Tipo_rol = rolDto.Tipo_rol,
                Estado = rolDto.Estado
            };

            _context.Rol.Add(rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRol", new { id = rol.Id_rol }, rol);
        }

        // DELETE: api/Rol/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol(int id)
        {
            var rol = await _context.Rol.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            _context.Rol.Remove(rol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolExists(int id)
        {
            return _context.Rol.Any(e => e.Id_rol == id);
        }
    }
}
