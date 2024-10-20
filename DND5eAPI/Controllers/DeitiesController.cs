using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeitiesController(ApiDbContext context) : ControllerBase
    {
        private readonly ApiDbContext _context = context;

        // GET: api/Deities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deity>>> GetDeity()
        {
            var res = await _context.Deity.ToListAsync();
            return res != null ? Ok(res) : NotFound("No deities");
        }

        // GET: api/Deities/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Deity>> GetDeity(int id)
        {
            var deity = await _context.Deity.FindAsync(id);
            return deity != null ? Ok(deity) : NotFound("Deity with provided id was not found");
        }

        // GET: api/Deities/mystra
        [HttpGet("{name}")]
        public async Task<ActionResult<Deity>> GetDeityByName(string name)
        {
            var deity = await _context.Deity.FirstOrDefaultAsync(d => d.Name == name);
            return deity != null ? Ok(deity) : NotFound("Deity with provided name was not found");
        }
    }
}
