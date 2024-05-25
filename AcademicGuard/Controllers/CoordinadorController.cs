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
        public async Task<IActionResult> PutCoordinador(int id, CoordinadorDto coordinadorDto)
        {
            //if (id != coordinadorDto.Id_coordinador)
            //{
            //    return BadRequest();
            //}

            var coordinador = await _context.Coordinador.FindAsync(id);
            if (coordinador == null)
            {
                return NotFound();
            }

            coordinador.Id_persona = coordinadorDto.Id_persona;
            coordinador.Titulo = coordinadorDto.Titulo;
            coordinador.Especialidad = coordinadorDto.Especialidad;
            coordinador.Fecha_contratacion = coordinadorDto.Fecha_contratacion;
            coordinador.Periodo_mandato = coordinadorDto.Periodo_mandato;
            coordinador.Estado = coordinadorDto.Estado;

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
        public async Task<ActionResult<Coordinador>> PostCoordinador(CoordinadorDto coordinadorDto)
        {
            var coordinador = new Coordinador
            {
                Id_persona = coordinadorDto.Id_persona,
                Titulo = coordinadorDto.Titulo,
                Especialidad = coordinadorDto.Especialidad,
                Fecha_contratacion = coordinadorDto.Fecha_contratacion,
                Periodo_mandato = coordinadorDto.Periodo_mandato,
                Estado = coordinadorDto.Estado
            };

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
