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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermiso(int id, PermisoDto permisoDto)
        {
            //if (id != permisoDto.Id_permiso)
            //{
            //    return BadRequest();
            //}

            var permiso = await _context.Permiso.FindAsync(id);
            if (permiso == null)
            {
                return NotFound();
            }

            permiso.Id_estudiante = permisoDto.Id_estudiante;
            permiso.Id_profesor = permisoDto.Id_profesor;
            permiso.Id_coordinador = permisoDto.Id_coordinador;
            permiso.Motivo = permisoDto.Motivo;
            permiso.Documento_adjunto = permisoDto.Documento_adjunto;
            permiso.Descripcion = permisoDto.Descripcion;
            permiso.Fecha_solicitud = permisoDto.Fecha_solicitud;
            permiso.Fecha_respuesta = permisoDto.Fecha_respuesta;
            permiso.Estado = permisoDto.Estado;
            permiso.Estado_aceptacion = permisoDto.Estado_aceptacion;

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
        [HttpPost]
        public async Task<ActionResult<Permiso>> PostPermiso(PermisoDto permisoDto)
        {
            var permiso = new Permiso
            {
                Id_estudiante = permisoDto.Id_estudiante,
                Id_profesor = permisoDto.Id_profesor,
                Id_coordinador = permisoDto.Id_coordinador,
                Motivo = permisoDto.Motivo,
                Documento_adjunto = permisoDto.Documento_adjunto,
                Descripcion = permisoDto.Descripcion,
                Fecha_solicitud = permisoDto.Fecha_solicitud,
                Fecha_respuesta = permisoDto.Fecha_respuesta,
                Estado = permisoDto.Estado,
                Estado_aceptacion = permisoDto.Estado_aceptacion
            };

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
