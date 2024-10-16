using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorController : Controller
    {
        private readonly ApiDbContext _context;

        public ArmorController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/armor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armor>>> GetArmor()
        {
            var res = await _context.Armor.Include(a => a.ArmorType).ToListAsync();
            return res != null ? Ok(res) : NotFound();
        }

        // GET: api/armor/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Armor>> GetArmorById(int id)
        {
            var armor = await _context.Armor.FindAsync(id);
            return armor != null ? Ok(armor) : NotFound();
        }

        // GET: api/armor/adamantine-armor
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Armor>> GetArmorByName(string indexName)
        {
            var armor = await _context.Armor.FirstOrDefaultAsync(a => a.IndexName == indexName);
            return armor != null ? Ok(armor) : NotFound();
        }
    }
}
