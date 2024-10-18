using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public WeaponsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Weapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapon()
        {
            var res = await _context.Weapon.ToListAsync();
            return res != null ? Ok(res) : NotFound("No weapons");
        }

        // GET: api/Weapons/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
            var weapon = await _context.Weapon.FindAsync(id);
            return weapon != null ? Ok(weapon) : NotFound("Weapon with provided id was not found");
        }

        // GET: api/Weapons/javelin-of-lightning 
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Weapon>> GetWeapon(string indexName)
        {
            var weapon = await _context.Weapon.FirstOrDefaultAsync(w => w.IndexName == indexName);
            return weapon != null ? Ok(weapon) : NotFound("Weapon with provided name was not found");
        }
    }
}
