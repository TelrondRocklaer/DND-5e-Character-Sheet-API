using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentCategoriesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public EquipmentCategoriesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/EquipmentCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentCategory>>> GetEquipmentCategory()
        {
            var res = await _context.EquipmentCategory.ToListAsync();
            return res != null ? Ok(res) : NotFound("No equipment categories");
        }

        // GET: api/EquipmentCategories/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EquipmentCategory>> GetEquipmentCategory(int id)
        {
            var equipmentCategory = await _context.EquipmentCategory.FindAsync(id);
            return equipmentCategory != null ? Ok(equipmentCategory) : NotFound("Equipment category with provided id was not found");
        }

        // GET: api/EquipmentCategories/potion
        [HttpGet("{name}")]
        public async Task<ActionResult<EquipmentCategory>> GetEquipmentCategory(string name)
        {
            var equipmentCategory = await _context.EquipmentCategory.FirstOrDefaultAsync(ec => ec.Name == name);
            return equipmentCategory != null ? Ok(equipmentCategory) : NotFound("Equipment category with provided name was not found");
        }
    }
}
