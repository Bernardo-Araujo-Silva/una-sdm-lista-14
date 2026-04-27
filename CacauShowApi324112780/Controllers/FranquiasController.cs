using Microsoft.AspNetCore.Mvc;
using CacauShowApi324112780.Data;
using CacauShowApi324112780.Models;

namespace CacauShowApi324112780.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FranquiasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FranquiasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Franquias.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Franquia franquia)
        {
            _context.Franquias.Add(franquia);
            _context.SaveChanges();
            return Ok(franquia);
        }
    }
}