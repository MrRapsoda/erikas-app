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
    public class accesoriossesController : ControllerBase
    {
        private readonly ErikasApiContext _context;

        public accesoriossesController(ErikasApiContext context)
        {
            _context = context;
        }

        // GET: api/accesoriosses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<accesorioss>>> Getaccesorioss()
        {
            return await _context.accesorioss.ToListAsync();
        }

        // GET: api/accesoriosses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<accesorioss>> Getaccesorioss(int id)
        {
            var accesorioss = await _context.accesorioss.FindAsync(id);

            if (accesorioss == null)
            {
                return NotFound();
            }

            return accesorioss;
        }

        // PUT: api/accesoriosses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putaccesorioss(int id, accesorioss accesorioss)
        {
            if (id != accesorioss.idAccesorio)
            {
                return BadRequest();
            }

            _context.Entry(accesorioss).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!accesoriossExists(id))
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

        // POST: api/accesoriosses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<accesorioss>> Postaccesorioss(accesorioss accesorioss)
        {
            _context.accesorioss.Add(accesorioss);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getaccesorioss", new { id = accesorioss.idAccesorio }, accesorioss);
        }

        // DELETE: api/accesoriosses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteaccesorioss(int id)
        {
            var accesorioss = await _context.accesorioss.FindAsync(id);
            if (accesorioss == null)
            {
                return NotFound();
            }

            _context.accesorioss.Remove(accesorioss);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool accesoriossExists(int id)
        {
            return _context.accesorioss.Any(e => e.idAccesorio == id);
        }
    }
}
