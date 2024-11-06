using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

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
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerCharacter>> GetPlayerCharacter(string id)
        {
            var playerCharacter = await _context.PlayerCharacter.FindAsync(id);
            return playerCharacter != null ? Ok(playerCharacter) : NotFound("Player character with provided id not found");
        }

        // POST: api/PlayerCharacters
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

        // DELETE: api/PlayerCharacters/5
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
