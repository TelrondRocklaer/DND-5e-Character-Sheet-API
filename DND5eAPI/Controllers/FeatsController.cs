using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public FeatsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Feats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feat>>> GetFeat()
        {
            var res = await _context.Feat.ToListAsync();
            return res != null ? Ok(res) : NotFound("No feats");
        }

        // GET: api/Feats/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Feat>> GetFeat(int id)
        {
            var feat = await _context.Feat.FindAsync(id);
            return feat != null ? Ok(feat) : NotFound("Feat with provided id was not found");
        }

        // GET: api/Feats/sharpshooter
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Feat>> GetFeat(string indexName)
        {
            var feat = await _context.Feat.FirstOrDefaultAsync(f => f.IndexName == indexName);
            return feat != null ? Ok(feat) : NotFound("Feat with provided id was not found");
        }
    }
}
