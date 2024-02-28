using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lotto5API.Data;
using Lotto5Adat.Models;

namespace Lotto5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LottoSzamsController : ControllerBase
    {
        private readonly Lotto5APIContext _context;

        public LottoSzamsController(Lotto5APIContext context)
        {
            _context = context;
        }

        // GET: api/LottoSzams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LottoSzam>>> GetLottoSzam()
        {
          if (_context.LottoSzam == null)
          {
              return NotFound();
          }
            return await _context.LottoSzam.ToListAsync();
        }

        // GET: api/LottoSzams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LottoSzam>> GetLottoSzam(int id)
        {
          if (_context.LottoSzam == null)
          {
              return NotFound();
          }
            var lottoSzam = await _context.LottoSzam.FindAsync(id);

            if (lottoSzam == null)
            {
                return NotFound();
            }

            return lottoSzam;
        }

        // PUT: api/LottoSzams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLottoSzam(int id, LottoSzam lottoSzam)
        {
            if (id != lottoSzam.Id)
            {
                return BadRequest();
            }

            _context.Entry(lottoSzam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LottoSzamExists(id))
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

        // POST: api/LottoSzams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LottoSzam>> PostLottoSzam(LottoSzam lottoSzam)
        {
          if (_context.LottoSzam == null)
          {
              return Problem("Entity set 'Lotto5APIContext.LottoSzam'  is null.");
          }
            _context.LottoSzam.Add(lottoSzam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLottoSzam", new { id = lottoSzam.Id }, lottoSzam);
        }

        // DELETE: api/LottoSzams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLottoSzam(int id)
        {
            if (_context.LottoSzam == null)
            {
                return NotFound();
            }
            var lottoSzam = await _context.LottoSzam.FindAsync(id);
            if (lottoSzam == null)
            {
                return NotFound();
            }

            _context.LottoSzam.Remove(lottoSzam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LottoSzamExists(int id)
        {
            return (_context.LottoSzam?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
