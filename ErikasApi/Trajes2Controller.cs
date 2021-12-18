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
    public class Trajes2Controller : ControllerBase
    {
        private readonly ErikasApiContext _context;

        public Trajes2Controller(ErikasApiContext context)
        {
            _context = context;
        }

        // GET: api/Trajes2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trajes2>>> GetTrajes2()
        {
            return await _context.Trajes2.ToListAsync();
        }

        // GET: api/Trajes2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trajes2>> GetTrajes2(int id)
        {
            var trajes2 = await _context.Trajes2.FindAsync(id);

            if (trajes2 == null)
            {
                return NotFound();
            }

            return trajes2;
        }

        // PUT: api/Trajes2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrajes2(int id, Trajes2 trajes2)
        {
            if (id != trajes2.idTraje)
            {
                return BadRequest();
            }

            _context.Entry(trajes2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Trajes2Exists(id))
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

        // POST: api/Trajes2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Trajes2>> PostTrajes2(Trajes2 trajes2)
        {
            _context.Trajes2.Add(trajes2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrajes2", new { id = trajes2.idTraje }, trajes2);
        }

        // DELETE: api/Trajes2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrajes2(int id)
        {
            var trajes2 = await _context.Trajes2.FindAsync(id);
            if (trajes2 == null)
            {
                return NotFound();
            }

            _context.Trajes2.Remove(trajes2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Trajes2Exists(int id)
        {
            return _context.Trajes2.Any(e => e.idTraje == id);
        }
    }
}
