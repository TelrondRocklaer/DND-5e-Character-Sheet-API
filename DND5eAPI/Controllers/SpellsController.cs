using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public SpellsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Spells
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spell>>> GetSpell()
        {
            var res = await _context.Spell.ToListAsync();
            return res != null ? Ok(res) : NotFound("No spells");
        }

        // GET: api/Spells/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Spell>> GetSpell(int id)
        {
            var spell = await _context.Spell.FindAsync(id);
            return spell != null ? Ok(spell) : NotFound("Spell with provided id was not found");
        }

        // GET: api/Spells/firebolt
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Spell>> GetSpell(string indexName)
        {
            var spell = await _context.Spell.FirstOrDefaultAsync(s => s.IndexName == indexName);
            return spell != null ? Ok(spell) : NotFound("Spell with provided name was not found");
        }
    }
}
