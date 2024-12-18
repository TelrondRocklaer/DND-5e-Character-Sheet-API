using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;
using Microsoft.AspNetCore.Authorization;
using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharactersController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PlayerCharactersController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/PlayerCharacters/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerCharacter>> GetPlayerCharacter(string id)
        {
            var playerCharacter = await _context.PlayerCharacter
                .Include(p => p.Race)
                .Include(p => p.Subrace)
                .Include(p => p.Class)
                .Include(p => p.Subclass)
                .Include(p => p.Background)
                .FirstOrDefaultAsync(p => p.Id == id);
            return playerCharacter != null ? Ok(playerCharacter) : NotFound("Player character with provided id not found");
        }

        // POST: api/PlayerCharacters
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<PlayerCharacter>> PostPlayerCharacter(PlayerCharacter playerCharacter)
        {
            _context.PlayerCharacter.Add(playerCharacter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PlayerCharacterExists(playerCharacter.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction("GetPlayerCharacter", new { id = playerCharacter.Id }, playerCharacter);
        }

        // PUT: api/PlayerCharacters/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerCharacter(string id, PlayerCharacter playerCharacter)
        {
            if (id != playerCharacter.Id)
            {
                return BadRequest();
            }
            _context.Entry(playerCharacter).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerCharacterExists(id))
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

        // DELETE: api/PlayerCharacters/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerCharacter(string id)
        {
            var playerCharacter = await _context.PlayerCharacter.FindAsync(id);
            if (playerCharacter == null)
            {
                return NotFound();
            }
            _context.PlayerCharacter.Remove(playerCharacter);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool PlayerCharacterExists(string id)
        {
            return _context.PlayerCharacter.Any(e => e.Id == id);
        }
    }
}
