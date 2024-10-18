using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public BackgroundsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Backgrounds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Background>>> GetBackground()
        {
            var res = await _context.Background.ToListAsync();
            return res != null ? Ok(res) : NotFound("No backgrounds");
        }

        // GET: api/Backgrounds/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Background>> GetBackground(int id)
        {
            var background = await _context.Background.FindAsync(id);
            return background != null ? Ok(background) : NotFound("Background with provided id was not found");
        }

        // GET: api/Backgrounds/Acolyte
        [HttpGet("{name}")]
        public async Task<ActionResult<Background>> GetBackground(string name)
        {
            var background = await _context.Background.FirstOrDefaultAsync(b => b.Name == name);
            return background != null ? Ok(background) : NotFound("Background with provided name was not found");
        }
    }
}
