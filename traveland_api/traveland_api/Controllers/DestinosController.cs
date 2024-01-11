using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using traveland_api.Context;
using traveland_api.Models;

namespace traveland_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        private readonly DataContext _context;

        public DestinosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Destinos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destinos>>> GetDestinos()
        {
            return await _context.Destinos.ToListAsync();
        }

        // GET: api/Destinos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destinos>> GetDestinos(int id)
        {
            var destinos = await _context.Destinos.FindAsync(id);

            if (destinos == null)
            {
                return NotFound();
            }

            return destinos;
        }

        // PUT: api/Destinos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestinos(int id, Destinos destinos)
        {
            if (id != destinos.id_destino)
            {
                return BadRequest();
            }

            _context.Entry(destinos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinosExists(id))
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

        // POST: api/Destinos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destinos>> PostDestinos(Destinos destinos)
        {
            _context.Destinos.Add(destinos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestinos", new { id = destinos.id_destino }, destinos);
        }

        // DELETE: api/Destinos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestinos(int id)
        {
            var destinos = await _context.Destinos.FindAsync(id);
            if (destinos == null)
            {
                return NotFound();
            }

            _context.Destinos.Remove(destinos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinosExists(int id)
        {
            return _context.Destinos.Any(e => e.id_destino == id);
        }
    }
}
