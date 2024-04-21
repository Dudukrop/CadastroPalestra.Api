using CadastroPalestra.Data;
using CadastroPalestra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CadastroPalestra.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var participantes = await _context.Participante.ToListAsync() ?? new List<Participante>();
            return Ok(participantes);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Participante participante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participante);
                await _context.SaveChangesAsync();
                return Ok(participante);
            }
            ModelState.AddModelError("Error", "Não foi possível adicionar o participante.");
            return BadRequest(ModelState);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var participante = await _context.Participante.FindAsync(id);
            if (participante != null)
            {
                _context.Remove(participante);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            ModelState.AddModelError("Error", "Id inválido.");
            return BadRequest(ModelState);
        }
    }
}
