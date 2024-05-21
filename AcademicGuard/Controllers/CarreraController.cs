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
    public class CarreraController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarreraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Carrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrera>>> GetCarrera()
        {
            return await _context.Carrera.ToListAsync();
        }

        // GET: api/Carrera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrera>> GetCarrera(int id)
        {
            var carrera = await _context.Carrera.FindAsync(id);

            if (carrera == null)
            {
                return NotFound();
            }

            return carrera;
        }

        // PUT: api/Carrera/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrera(int id, CarreraDto carreraDto)
        {
            //if (id != carreraDto.Id_carrera)
            //{
            //    return BadRequest();
            //}

            var carrera = await _context.Carrera.FindAsync(id);
            if (carrera == null)
            {
                return NotFound();
            }

            carrera.Id_curso = carreraDto.Id_curso;
            carrera.Id_coordinador = carreraDto.Id_coordinador;
            carrera.Nombre = carreraDto.Nombre;
            carrera.Descripcion = carreraDto.Descripcion;
            carrera.Duracion = carreraDto.Duracion;
            carrera.Carrera_habilitada = carreraDto.Carrera_habilitada;
            carrera.Estado = carreraDto.Estado;

            _context.Entry(carrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarreraExists(id))
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

        // POST: api/Carrera
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carrera>> PostCarrera(CarreraDto carreraDto)
        {
            var carrera = new Carrera
            {
                Id_curso = carreraDto.Id_curso,
                Id_coordinador = carreraDto.Id_coordinador,
                Nombre = carreraDto.Nombre,
                Descripcion = carreraDto.Descripcion,
                Duracion = carreraDto.Duracion,
                Carrera_habilitada = carreraDto.Carrera_habilitada,
                Estado = carreraDto.Estado
            };

            _context.Carrera.Add(carrera);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarrera", new { id = carrera.Id_carrera }, carrera);
        }

        // DELETE: api/Carrera/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarrera(int id)
        {
            var carrera = await _context.Carrera.FindAsync(id);
            if (carrera == null)
            {
                return NotFound();
            }

            _context.Carrera.Remove(carrera);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarreraExists(int id)
        {
            return _context.Carrera.Any(e => e.Id_carrera == id);
        }
    }
}
