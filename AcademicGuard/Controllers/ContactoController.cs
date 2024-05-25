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
    public class ContactoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Contacto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contacto>>> GetContacto()
        {
            return await _context.Contacto.ToListAsync();
        }

        // GET: api/Contacto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contacto>> GetContacto(int id)
        {
            var contacto = await _context.Contacto.FindAsync(id);

            if (contacto == null)
            {
                return NotFound();
            }

            return contacto;
        }

        // PUT: api/Contacto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContacto(int id, ContactoDto contactoDto)
        {
            //if (id != contactoDto.Id_contacto)
            //{
            //    return BadRequest();
            //}

            var contacto = await _context.Contacto.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }

            contacto.Id_detalle_persona = contactoDto.Id_detalle_persona;
            contacto.Telefono_1 = contactoDto.Telefono_1;
            contacto.Telefono_2 = contactoDto.Telefono_2;
            contacto.Telefono_casa = contactoDto.Telefono_casa;
            contacto.Estado = contactoDto.Estado;

            _context.Entry(contacto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactoExists(id))
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

        // POST: api/Contacto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contacto>> PostContacto(ContactoDto contactoDto)
        {
            var contacto = new Contacto
            {
                Id_detalle_persona = contactoDto.Id_detalle_persona,
                Telefono_1 = contactoDto.Telefono_1,
                Telefono_2 = contactoDto.Telefono_2,
                Telefono_casa = contactoDto.Telefono_casa,
                Estado = contactoDto.Estado
            };

            _context.Contacto.Add(contacto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContacto", new { id = contacto.Id_contacto }, contacto);
        }

        // DELETE: api/Contacto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContacto(int id)
        {
            var contacto = await _context.Contacto.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }

            _context.Contacto.Remove(contacto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactoExists(int id)
        {
            return _context.Contacto.Any(e => e.Id_contacto == id);
        }
    }
}
