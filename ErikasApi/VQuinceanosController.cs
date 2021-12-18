using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ErikasApi.Data;
using ErikasApi.Models;

namespace ErikasApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class VQuinceanosController : ControllerBase
    {
        private readonly ErikasApiContext _context;

        public VQuinceanosController(ErikasApiContext context)
        {
            _context = context;
        }

        // GET: api/VQuinceanos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VQuinceanos>>> GetVQuinceanos()
        {
            return await _context.VQuinceanos.ToListAsync();
        }

        // GET: api/VQuinceanos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VQuinceanos>> GetVQuinceanos(int id)
        {
            var vQuinceanos = await _context.VQuinceanos.FindAsync(id);

            if (vQuinceanos == null)
            {
                return NotFound();
            }

            return vQuinceanos;
        }

        // PUT: api/VQuinceanos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVQuinceanos(int id, VQuinceanos vQuinceanos)
        {
            if (id != vQuinceanos.idQuinceanos)
            {
                return BadRequest();
            }

            _context.Entry(vQuinceanos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VQuinceanosExists(id))
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

        // POST: api/VQuinceanos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VQuinceanos>> PostVQuinceanos(VQuinceanos vQuinceanos)
        {
            _context.VQuinceanos.Add(vQuinceanos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVQuinceanos", new { id = vQuinceanos.idQuinceanos }, vQuinceanos);
        }

        // DELETE: api/VQuinceanos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVQuinceanos(int id)
        {
            var vQuinceanos = await _context.VQuinceanos.FindAsync(id);
            if (vQuinceanos == null)
            {
                return NotFound();
            }

            _context.VQuinceanos.Remove(vQuinceanos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VQuinceanosExists(int id)
        {
            return _context.VQuinceanos.Any(e => e.idQuinceanos == id);
        }
    }
}
