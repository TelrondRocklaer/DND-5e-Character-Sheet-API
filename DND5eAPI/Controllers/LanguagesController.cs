using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public LanguagesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Languages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Language>>> GetLanguage()
        {
            var res = await _context.Language.ToListAsync();
            return res != null ? Ok(res) : NotFound("No languages");
        }

        // GET: api/Languages/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Language>> GetLanguage(int id)
        {
            var language = await _context.Language.FindAsync(id);
            return language != null ? Ok(language) : NotFound("Language with provided id was not found");
        }

        // GET: api/Languages/5
        [HttpGet("{name}")]
        public async Task<ActionResult<Language>> GetLanguage(string name)
        {
            var language = await _context.Language.FirstOrDefaultAsync(l => l.Name == name);
            return language != null ? Ok(language) : NotFound("Language with provided name was not found");
        }
    }
}
