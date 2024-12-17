using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

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
            var res = await _context.Armor.Include(a => a.ArmorType).ToListAsync();
            return res != null ? Ok(res) : NotFound("No armor");
        }

        // GET: api/Armor/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Armor>> GetArmorById(int id)
        {
            var armor = await _context.Armor.Include(a => a.ArmorType).FirstOrDefaultAsync(a => a.Id == id);
            return armor != null ? Ok(armor) : NotFound("Armor with provided id was not found");
        }

        // GET: api/Armor/adamantine-armor
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Armor>> GetArmorByName(string indexName)
        {
            var armor = await _context.Armor.Include(a => a.ArmorType).FirstOrDefaultAsync(a => a.IndexName == indexName);
            return armor != null ? Ok(armor) : NotFound("Armor with provided name was not found");
        }
    }
}
