using Microsoft.AspNetCore.Mvc;
using ProyectoDispositivosPrestamo.Data;
using ProyectoDispositivosPrestamo.Models;

namespace ProyectoDispositivosPrestamo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstudiantesController(AppDbContext context)
        {
            _context = context;
        }

        // CREATE
        [HttpPost]
        public async Task<ActionResult<Estudiante>> CreateEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEstudiante), new { id = estudiante.Id }, estudiante);
        }

        // READ (ALL)
        [HttpGet]
        public ActionResult<IEnumerable<Estudiante>> GetEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }

        // READ (ONE)
        [HttpGet("{id}")]
        public ActionResult<Estudiante> GetEstudiante(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            if (estudiante == null)
                return NotFound();
            return estudiante;
        }

        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEstudiante(int id, Estudiante estudiante)
        {
            if (id != estudiante.Id)
                return BadRequest();

            _context.Entry(estudiante).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudiante(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            if (estudiante == null)
                return NotFound();

            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}