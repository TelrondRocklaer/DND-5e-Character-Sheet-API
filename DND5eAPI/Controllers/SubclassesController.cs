using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubclassesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public SubclassesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Subclasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subclass>>> GetSubclass()
        {
            var res = await _context.Subclass.ToListAsync();
            return res != null ? Ok(res) : NotFound("No subclasses");
        }

        // GET: api/Subclasses/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Subclass>> GetSubclass(int id)
        {
            var subclass = await _context.Subclass.FindAsync(id);
            return subclass != null ? Ok(subclass) : NotFound("Subclass with provided id was not found");
        }

        // GET: api/Subclasses/battle-master
        [HttpGet("{name}")]
        public async Task<ActionResult<Subclass>> GetSubclassByName(string name)
        {
            var subclass = await _context.Subclass.FirstOrDefaultAsync(s => s.Name == name);
            return subclass != null ? Ok(subclass) : NotFound("Subclass with provided name was not found");
        }
    }
}
