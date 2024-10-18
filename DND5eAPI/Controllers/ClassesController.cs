using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ClassesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClass()
        {
            var res = await _context.Class.ToListAsync();
            return res != null ? Ok(res) : NotFound("No classes");
        }

        // GET: api/Classes/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var @class = await _context.Class.FindAsync(id);
            return @class != null ? Ok(@class) : NotFound("Class with provided id was not found");
        }

        // GET: api/Classes/Barbarian
        [HttpGet("{name}")]
        public async Task<ActionResult<Class>> GetClass(string name)
        {
            var @class = await _context.Class.FirstOrDefaultAsync(c => c.Name == name);
            return @class != null ? Ok(@class) : NotFound("Class with provided name was not found");
        }
    }
}
