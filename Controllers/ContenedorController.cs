using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIContainers.Data;
using APIContainers.Models;

namespace APIContainers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContenedorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContenedorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contenedor>>> GetContenedores()
        {
            return await _context.Contenedores.ToListAsync();
        }
    }
}
