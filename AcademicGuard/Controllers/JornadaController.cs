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
    public class JornadaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JornadaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Jornada
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jornada>>> GetJornada()
        {
            return await _context.Jornada.ToListAsync();
        }

        // GET: api/Jornada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jornada>> GetJornada(int id)
        {
            var jornada = await _context.Jornada.FindAsync(id);

            if (jornada == null)
            {
                return NotFound();
            }

            return jornada;
        }

        // PUT: api/Jornada/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJornada(int id, JornadaDto jornadaDto)
        {
            if (id != jornadaDto.Id_jornada)
            {
                return BadRequest();
            }

            var jornada = await _context.Jornada.FindAsync(id);
            if (jornada == null)
            {
                return NotFound();
            }

            jornada.Id_curso = jornadaDto.Id_curso;
            jornada.Tipo_jornada = jornadaDto.Tipo_jornada;
            jornada.Jornada_habilitada = jornadaDto.Jornada_habilitada;
            jornada.Estado = jornadaDto.Estado;

            _context.Entry(jornada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JornadaExists(id))
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

        // POST: api/Jornada
        [HttpPost]
        public async Task<ActionResult<Jornada>> PostJornada(JornadaDto jornadaDto)
        {
            var jornada = new Jornada
            {
                Id_curso = jornadaDto.Id_curso,
                Tipo_jornada = jornadaDto.Tipo_jornada,
                Jornada_habilitada = jornadaDto.Jornada_habilitada,
                Estado = jornadaDto.Estado
            };

            _context.Jornada.Add(jornada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJornada", new { id = jornada.Id_jornada }, jornada);
        }

        // DELETE: api/Jornada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJornada(int id)
        {
            var jornada = await _context.Jornada.FindAsync(id);
            if (jornada == null)
            {
                return NotFound();
            }

            _context.Jornada.Remove(jornada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JornadaExists(int id)
        {
            return _context.Jornada.Any(e => e.Id_jornada == id);
        }
    }
}
