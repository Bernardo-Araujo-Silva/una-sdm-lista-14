using Microsoft.AspNetCore.Mvc;
using CacauShowApi324112780.Data;
using CacauShowApi324112780.Models;

namespace CacauShowApi324112780.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Produtos.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}