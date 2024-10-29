using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;
using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorController(ApiDbContext context) : Controller
    {
        private readonly ApiDbContext _context = context;

        // GET: api/Armor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armor>>> GetArmor()
        {
            var res = await _context.Armor.ToListAsync();
            return res != null ? Ok(res) : NotFound("No armor");
        }

        // GET: api/Armor/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Armor>> GetArmorById(int id)
        {
            var armor = await _context.Armor.FindAsync(id);
            return armor != null ? Ok(armor) : NotFound("Armor with provided id was not found");
        }

        // GET: api/Armor/adamantine-armor
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Armor>> GetArmorByName(string indexName)
        {
            var armor = await _context.Armor.FirstOrDefaultAsync(a => a.IndexName == indexName);
            return armor != null ? Ok(armor) : NotFound("Armor with provided name was not found");
        }
    }
}
