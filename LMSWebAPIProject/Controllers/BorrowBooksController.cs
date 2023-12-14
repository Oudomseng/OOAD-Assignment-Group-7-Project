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
    public class BorrowBooksController : ControllerBase
    {
        private readonly LMSContext _context;

        public BorrowBooksController(LMSContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/BorrowBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BorrowBook>>> GetBorrowBooks()
        {
          if (_context.BorrowBooks == null)
          {
              return NotFound();
          }
            return await _context.BorrowBooks.ToListAsync();
        }

        // GET: api/BorrowBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BorrowBook>> GetBorrowBook(int id)
        {
          if (_context.BorrowBooks == null)
          {
              return NotFound();
          }
            var borrowBook = await _context.BorrowBooks.FindAsync(id);

            if (borrowBook == null)
            {
                return NotFound();
            }

            return borrowBook;
        }

        // PUT: api/BorrowBooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBorrowBook(int id, BorrowBook borrowBook)
        {
            if (id != borrowBook.BorrowBookId)
            {
                return BadRequest();
            }

            _context.Entry(borrowBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorrowBookExists(id))
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

        // POST: api/BorrowBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BorrowBook>> PostBorrowBook(BorrowBook borrowBook)
        {
          if (_context.BorrowBooks == null)
          {
              return Problem("Entity set 'LMSContext.BorrowBooks'  is null.");
          }
            _context.BorrowBooks.Add(borrowBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBorrowBook", new { id = borrowBook.BorrowBookId }, borrowBook);
        }

        // DELETE: api/BorrowBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBorrowBook(int id)
        {
            if (_context.BorrowBooks == null)
            {
                return NotFound();
            }
            var borrowBook = await _context.BorrowBooks.FindAsync(id);
            if (borrowBook == null)
            {
                return NotFound();
            }

            _context.BorrowBooks.Remove(borrowBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BorrowBookExists(int id)
        {
            return (_context.BorrowBooks?.Any(e => e.BorrowBookId == id)).GetValueOrDefault();
        }
    }
}
