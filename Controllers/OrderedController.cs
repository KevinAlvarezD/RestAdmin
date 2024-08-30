using Microsoft.AspNetCore.Mvc;
using RestAdmin.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Data; // Ajusta este namespace si es necesario

namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderedController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrderedController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ordered
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetOrdereds()
        {
            return await _context.Ordereds.ToListAsync();
        }

        // GET: api/Ordered/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ordered>> GetOrdered(int id)
        {
            var ordered = await _context.Ordereds.FindAsync(id);

            if (ordered == null)
            {
                return NotFound();
            }

            return ordered;
        }

        // PUT: api/Ordered/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdered(int id, Ordered ordered)
        {
            if (id != ordered.Id)
            {
                return BadRequest();
            }

            _context.Entry(ordered).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderedExists(id))
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

        // POST: api/Ordered
        [HttpPost]
        public async Task<ActionResult<Ordered>> PostOrdered(Ordered ordered)
        {
            _context.Ordereds.Add(ordered);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdered", new { id = ordered.Id }, ordered);
        }

        // DELETE: api/Ordered/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdered(int id)
        {
            var ordered = await _context.Ordereds.FindAsync(id);
            if (ordered == null)
            {
                return NotFound();
            }

            _context.Ordereds.Remove(ordered);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderedExists(int id)
        {
            return _context.Ordereds.Any(e => e.Id == id);
        }
    }
}