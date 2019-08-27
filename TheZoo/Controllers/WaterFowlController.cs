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
    [Route("api/WaterFowl")]
    [ApiController]
    public class WaterFowlController : ControllerBase
    {
        private readonly TheZooDB _context;

        public WaterFowlController(TheZooDB context)
        {
            _context = context;
        }

        // GET: api/WaterFowl
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WaterFowl>>> GetWaterFowlGroup()
        {
            return await _context.WaterFowlGroup.ToListAsync();
        }

        // GET: api/WaterFowl/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WaterFowl>> GetWaterFowl(int id)
        {
            var waterFowl = await _context.WaterFowlGroup.FindAsync(id);

            if (waterFowl == null)
            {
                return NotFound();
            }

            return waterFowl;
        }

        // PUT: api/WaterFowl/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWaterFowl(int id, WaterFowl waterFowl)
        {
            if (id != waterFowl.Id)
            {
                return BadRequest();
            }

            _context.Entry(waterFowl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WaterFowlExists(id))
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

        // POST: api/WaterFowl
        [HttpPost]
        public async Task<ActionResult<WaterFowl>> PostWaterFowl(WaterFowl waterFowl)
        {
            _context.WaterFowlGroup.Add(waterFowl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWaterFowl", new { id = waterFowl.Id }, waterFowl);
        }

        // DELETE: api/WaterFowl/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WaterFowl>> DeleteWaterFowl(int id)
        {
            var waterFowl = await _context.WaterFowlGroup.FindAsync(id);
            if (waterFowl == null)
            {
                return NotFound();
            }

            _context.WaterFowlGroup.Remove(waterFowl);
            await _context.SaveChangesAsync();

            return waterFowl;
        }

        private bool WaterFowlExists(int id)
        {
            return _context.WaterFowlGroup.Any(e => e.Id == id);
        }
    }
}
