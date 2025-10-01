using Microsoft.AspNetCore.Mvc;
using ProyectoDispositivosPrestamo.Data;
using ProyectoDispositivosPrestamo.Models;

namespace ProyectoDispositivosPrestamo.Controllers
{
    public class EstudiantesMvcController : Controller
    {
        private readonly AppDbContext _context;
        public EstudiantesMvcController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public IActionResult Index()
        {
            return View(_context.Estudiantes.ToList());
        }

        // GET: Estudiantes/Create
        public IActionResult Create() => View();

        // POST: Estudiantes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Estudiantes.Add(estudiante);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }

        // GET: Estudiantes/Edit/5
        public IActionResult Edit(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            if (estudiante == null) return NotFound();
            return View(estudiante);
        }

        // POST: Estudiantes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Update(estudiante);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }

        // GET: Estudiantes/Delete/5
        public IActionResult Delete(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            if (estudiante == null) return NotFound();
            return View(estudiante);
        }

        // POST: Estudiantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}