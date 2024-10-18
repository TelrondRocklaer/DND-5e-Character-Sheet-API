using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponTypesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public WeaponTypesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/WeaponTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponType>>> GetWeaponType()
        {
            var res = await _context.WeaponType.ToListAsync();
            return res != null ? Ok(res) : NotFound("No weapon types");
        }

        // GET: api/WeaponTypes/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<WeaponType>> GetWeaponType(int id)
        {
            var weaponType = await _context.WeaponType.FindAsync(id);
            return weaponType != null ? Ok(weaponType) : NotFound("Weapon type with provided id was not found");
        }

        // GET: api/WeaponTypes/shortsword
        [HttpGet("{name}")]
        public async Task<ActionResult<WeaponType>> GetWeaponType(string name)
        {
            var weaponType = await _context.WeaponType.FirstOrDefaultAsync(wt => wt.Name == name);
            return weaponType != null ? Ok(weaponType) : NotFound("Weapon type with provided name was not found");
        }
    }
}
