using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public EquipmentController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Equipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipment()
        {
            var res = await _context.Equipment.ToListAsync();
            return res != null ? Ok(res) : NotFound("No equipment");
        }

        // GET: api/Equipment/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Equipment>> GetEquipment(int id)
        {
            var equipment = await _context.Equipment.FindAsync(id);
            return equipment != null ? Ok(equipment) : NotFound("Equipment with provided id was not found");
        }

        // GET: api/Equipment/torch
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Equipment>> GetEquipment(string indexName)
        {
            var equipment = await _context.Equipment.FirstOrDefaultAsync(e => e.IndexName == indexName);
            return equipment != null ? Ok(equipment) : NotFound("Equipment with provided name was not found");
        }
    }
}
