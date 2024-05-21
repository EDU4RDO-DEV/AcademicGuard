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
    public class HorarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HorarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Horario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horario>>> GetHorario()
        {
            return await _context.Horario.ToListAsync();
        }

        // GET: api/Horario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Horario>> GetHorario(int id)
        {
            var horario = await _context.Horario.FindAsync(id);

            if (horario == null)
            {
                return NotFound();
            }

            return horario;
        }

        // PUT: api/Horario/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorario(int id, HorarioDto horarioDto)
        {
            //if (id != horarioDto.Id_horario)
            //{
            //    return BadRequest();
            //}

            var horario = await _context.Horario.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }

            horario.Id_curso = horarioDto.Id_curso;
            horario.Dia = horarioDto.Dia;
            horario.Hora_inicio = horarioDto.Hora_inicio;
            horario.Hora_fin = horarioDto.Hora_fin;
            horario.Horario_habilitado = horarioDto.Horario_habilitado;
            horario.Estado = horarioDto.Estado;

            _context.Entry(horario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorarioExists(id))
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

        // POST: api/Horario
        [HttpPost]
        public async Task<ActionResult<Horario>> PostHorario(HorarioDto horarioDto)
        {
            var horario = new Horario
            {
                Id_curso = horarioDto.Id_curso,
                Dia = horarioDto.Dia,
                Hora_inicio = horarioDto.Hora_inicio,
                Hora_fin = horarioDto.Hora_fin,
                Horario_habilitado = horarioDto.Horario_habilitado,
                Estado = horarioDto.Estado
            };

            _context.Horario.Add(horario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorario", new { id = horario.Id_horario }, horario);
        }

        // DELETE: api/Horario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHorario(int id)
        {
            var horario = await _context.Horario.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }

            _context.Horario.Remove(horario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorarioExists(int id)
        {
            return _context.Horario.Any(e => e.Id_horario == id);
        }
    }
}
