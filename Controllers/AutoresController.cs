using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaCSF.Data;
using PruebaCSF.Models;

namespace PruebaCSF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly DataContext _context;

        public AutoresController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public async Task<ActionResult<Autores>> CrearAutor(Autores autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAutor", new { id = autor.Id }, autor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarAutor(int id, Autores autor)
        {
            if (id != autor.Id) return BadRequest();

            _context.Entry(autor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autores>>> GetAutores()
        {
            return await _context.Autores.ToListAsync();
        }
    }
}
