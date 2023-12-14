using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMSWebAPIProject.Context;
using LMSWebAPIProject.Models;

namespace LMSWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OverduesController : ControllerBase
    {
        private readonly LMSContext _context;

        public OverduesController(LMSContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Overdues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Overdue>>> GetOverdues()
        {
          if (_context.Overdues == null)
          {
              return NotFound();
          }
            return await _context.Overdues.ToListAsync();
        }

        // GET: api/Overdues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Overdue>> GetOverdue(int id)
        {
          if (_context.Overdues == null)
          {
              return NotFound();
          }
            var overdue = await _context.Overdues.FindAsync(id);

            if (overdue == null)
            {
                return NotFound();
            }

            return overdue;
        }

        // PUT: api/Overdues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOverdue(int id, Overdue overdue)
        {
            if (id != overdue.Id)
            {
                return BadRequest();
            }

            _context.Entry(overdue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OverdueExists(id))
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

        // POST: api/Overdues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Overdue>> PostOverdue(Overdue overdue)
        {
          if (_context.Overdues == null)
          {
              return Problem("Entity set 'LMSContext.Overdues'  is null.");
          }
            _context.Overdues.Add(overdue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOverdue", new { id = overdue.Id }, overdue);
        }

        // DELETE: api/Overdues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOverdue(int id)
        {
            if (_context.Overdues == null)
            {
                return NotFound();
            }
            var overdue = await _context.Overdues.FindAsync(id);
            if (overdue == null)
            {
                return NotFound();
            }

            _context.Overdues.Remove(overdue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OverdueExists(int id)
        {
            return (_context.Overdues?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
