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
    public class VestidoesController : ControllerBase
    {
        private readonly ErikasApiContext _context;

        public VestidoesController(ErikasApiContext context)
        {
            _context = context;
        }

        // GET: api/Vestidoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vestido>>> GetVestido()
        {
            return await _context.Vestido.ToListAsync();
        }

        // GET: api/Vestidoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vestido>> GetVestido(int id)
        {
            var vestido = await _context.Vestido.FindAsync(id);

            if (vestido == null)
            {
                return NotFound();
            }

            return vestido;
        }

        // PUT: api/Vestidoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVestido(int id, Vestido vestido)
        {
            if (id != vestido.idVestidos)
            {
                return BadRequest();
            }

            _context.Entry(vestido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VestidoExists(id))
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

        // POST: api/Vestidoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vestido>> PostVestido(Vestido vestido)
        {
            _context.Vestido.Add(vestido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVestido", new { id = vestido.idVestidos }, vestido);
        }

        // DELETE: api/Vestidoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVestido(int id)
        {
            var vestido = await _context.Vestido.FindAsync(id);
            if (vestido == null)
            {
                return NotFound();
            }

            _context.Vestido.Remove(vestido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VestidoExists(int id)
        {
            return _context.Vestido.Any(e => e.idVestidos == id);
        }
    }
}
