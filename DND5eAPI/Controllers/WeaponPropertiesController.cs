using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponPropertiesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public WeaponPropertiesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/WeaponProperties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponProperty>>> GetWeaponProperty()
        {
            var res = await _context.WeaponProperty.ToListAsync();
            return res != null ? Ok(res) : NotFound("No weapon properties");
        }

        // GET: api/WeaponProperties/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<WeaponProperty>> GetWeaponProperty(int id)
        {
            var weaponProperty = await _context.WeaponProperty.FindAsync(id);
            return weaponProperty != null ? Ok(weaponProperty) : NotFound("Weapon property with provided id was not found");
        }

        // GET: api/WeaponProperties/light
        [HttpGet("{name}")]
        public async Task<ActionResult<WeaponProperty>> GetWeaponProperty(string name)
        {
            var weaponProperty = await _context.WeaponProperty.FirstOrDefaultAsync(wp => wp.Name == name);
            return weaponProperty != null ? Ok(weaponProperty) : NotFound("Weapon property with provided name was not found");
        }
    }
}
