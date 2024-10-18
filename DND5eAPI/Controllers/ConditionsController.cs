using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Models;

namespace DND5eAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ConditionsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Conditions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetCondition()
        {           
            var res = await _context.Condition.ToListAsync();
            return res != null ? Ok(res) : NotFound("No conditions");
        }

        // GET: api/Conditions/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Condition>> GetCondition(int id)
        {
            var condition = await _context.Condition.FindAsync(id);
            return condition != null ? Ok(condition) : NotFound("Condition with provided id was not found");
        }

        // GET: api/Conditions/blinded
        [HttpGet("{name}")]
        public async Task<ActionResult<Condition>> GetConditionByName(string name)
        {
            var condition = await _context.Condition.FirstOrDefaultAsync(c => c.Name == name);
            return condition != null ? Ok(condition) : NotFound("Condition with provided name was not found");
        }
    }
}
