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
    public class CursoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CursoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Curso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCurso()
        {
            return await _context.Curso.ToListAsync();
        }

        // GET: api/Curso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetCurso(int id)
        {
            var curso = await _context.Curso.FindAsync(id);

            if (curso == null)
            {
                return NotFound();
            }

            return curso;
        }

        // PUT: api/Curso/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso(int id, CursoDto cursoDto)
        {
            //if (id != cursoDto.Id_curso)
            //{
            //    return BadRequest();
            //}

            var curso = await _context.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            curso.Id_profesor = cursoDto.Id_profesor;
            curso.Id_estudiante = cursoDto.Id_estudiante;
            curso.Id_coordinador = cursoDto.Id_coordinador;
            curso.Nombre_curso = cursoDto.Nombre_curso;
            curso.Descripcion = cursoDto.Descripcion;
            curso.Estado = cursoDto.Estado;

            _context.Entry(curso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(id))
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

        // POST: api/Curso
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(CursoDto cursoDto)
        {
            var curso = new Curso
            {
                Id_profesor = cursoDto.Id_profesor,
                Id_estudiante = cursoDto.Id_estudiante,
                Id_coordinador = cursoDto.Id_coordinador,
                Nombre_curso = cursoDto.Nombre_curso,
                Descripcion = cursoDto.Descripcion,
                Estado = cursoDto.Estado
            };

            _context.Curso.Add(curso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurso", new { id = curso.Id_curso }, curso);
        }

        // DELETE: api/Curso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso(int id)
        {
            var curso = await _context.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            _context.Curso.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoExists(int id)
        {
            return _context.Curso.Any(e => e.Id_curso == id);
        }
    }
}
