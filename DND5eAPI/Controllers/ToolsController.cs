using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ToolsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Tools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tool>>> GetTool()
        {
            var res = await _context.Tool.ToListAsync();
            return res != null ? Ok(res) : NotFound("No tools");
        }

        // GET: api/Tools/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Tool>> GetTool(int id)
        {
            var tool = await _context.Tool.FindAsync(id);
            return tool != null ? Ok(tool) : NotFound("Tool with provided id was not found");
        }

        // GET: api/Tools/thieves-tools
        [HttpGet("{indexName}")]
        public async Task<ActionResult<Tool>> GetTool(string indexName)
        {
            var tool = await _context.Tool.FirstOrDefaultAsync(t => t.IndexName == indexName);
            return tool != null ? Ok(tool) : NotFound("Tool with provided name was not found");
        }
    }
}
