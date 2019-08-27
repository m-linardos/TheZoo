using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheZoo.Models;

namespace TheZoo.Controllers
{
    [Route("api/PettingZoo")]
    [ApiController]
    public class PettingZooController : ControllerBase
    {
        private readonly TheZooDB _context;

        public PettingZooController(TheZooDB context)
        {
            _context = context;
        }

        // GET: api/PettingZoo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PettingZoo>>> GetPettingZooAnimals()
        {
            return await _context.PettingZooAnimals.ToListAsync();
        }

        // GET: api/PettingZoo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PettingZoo>> GetPettingZoo(int id)
        {
            var pettingZoo = await _context.PettingZooAnimals.FindAsync(id);

            if (pettingZoo == null)
            {
                return NotFound();
            }

            return pettingZoo;
        }

        // PUT: api/PettingZoo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPettingZoo(int id, PettingZoo pettingZoo)
        {
            if (id != pettingZoo.Id)
            {
                return BadRequest();
            }

            _context.Entry(pettingZoo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PettingZooExists(id))
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

        // POST: api/PettingZoo
        [HttpPost]
        public async Task<ActionResult<PettingZoo>> PostPettingZoo(PettingZoo pettingZoo)
        {
            _context.PettingZooAnimals.Add(pettingZoo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPettingZoo", new { id = pettingZoo.Id }, pettingZoo);
        }

        // DELETE: api/PettingZoo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PettingZoo>> DeletePettingZoo(int id)
        {
            var pettingZoo = await _context.PettingZooAnimals.FindAsync(id);
            if (pettingZoo == null)
            {
                return NotFound();
            }

            _context.PettingZooAnimals.Remove(pettingZoo);
            await _context.SaveChangesAsync();

            return pettingZoo;
        }

        private bool PettingZooExists(int id)
        {
            return _context.PettingZooAnimals.Any(e => e.Id == id);
        }
    }
}
