using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public RacesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Races
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Race>>> GetRace()
        {
            var res = await _context.Race.ToListAsync();
            return res != null ? Ok(res) : NotFound("No races");
        }

        // GET: api/Races/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Race>> GetRace(int id)
        {
            var race = await _context.Race.FindAsync(id);
            return race != null ? Ok(race) : NotFound("Race with provided id was not found");
        }

        // GET: api/Races/dwarf
        [HttpGet("{name}")]
        public async Task<ActionResult<Race>> GetRace(string name)
        {
            var race = await _context.Race.FirstOrDefaultAsync(r => r.Name == name);
            return race != null ? Ok(race) : NotFound("Race with provided name was not found");
        }
    }
}
