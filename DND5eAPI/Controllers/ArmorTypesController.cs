using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorTypesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ArmorTypesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ArmorTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorType>>> GetArmorType()
        {
            var res = await _context.ArmorType.ToListAsync();
            return res != null ? Ok(res) : NotFound("No armor types");
        }

        // GET: api/ArmorTypes/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ArmorType>> GetArmorType(int id)
        {
            var armorType = await _context.ArmorType.FindAsync(id);
            return armorType != null ? Ok(armorType) : NotFound("Armor type with provided id was not found");
        }

        // GET: api/ArmorTypes/Light
        [HttpGet("{name}")]
        public async Task<ActionResult<ArmorType>> GetArmorType(string name)
        {
            var armorType = await _context.ArmorType.FirstOrDefaultAsync(a => a.Name == name);
            return armorType != null ? Ok(armorType) : NotFound("Armor type with provided name was not found");
        }
    }
}
