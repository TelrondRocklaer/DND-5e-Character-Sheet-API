using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubracesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public SubracesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Subraces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subrace>>> GetSubrace()
        {
            var res = await _context.Subrace.ToListAsync();
            return res != null ? Ok(res) : NotFound("No subraces");
        }

        // GET: api/Subraces/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Subrace>> GetSubrace(int id)
        {
            var subrace = await _context.Subrace.FindAsync(id);
            return subrace != null ? Ok(subrace) : NotFound("Subrace with provided id was not found");
        }

        // GET: api/Subraces/high-elf
        [HttpGet("{name}")]
        public async Task<ActionResult<Subrace>> GetSubraceByName(string name)
        {
            var subrace = await _context.Subrace.FirstOrDefaultAsync(s => s.Name == name);
            return subrace != null ? Ok(subrace) : NotFound("Subrace with provided name was not found");
        }
    }
}
