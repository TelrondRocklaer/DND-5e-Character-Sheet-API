using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraitsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TraitsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Traits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trait>>> GetTrait()
        {
            var res = await _context.Trait.ToListAsync();
            return res != null ? Ok(res) : NotFound("No traits");
        }

        // GET: api/Traits/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Trait>> GetTrait(int id)
        {
            var trait = await _context.Trait.FindAsync(id);
            return trait != null ? Ok(trait) : NotFound("Trait with provided id was not found");
        }

        // GET: api/Traits/aberrant-nature
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Trait>> GetTrait(string indexName)
        {
            var trait = await _context.Trait.FirstOrDefaultAsync(t => t.IndexName == indexName);
            return trait != null ? Ok(trait) : NotFound("Trait with provided name was not found");
        }
    }
}
