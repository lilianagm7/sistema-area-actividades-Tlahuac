using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Gestor_Eventos_Tlahuac.Data;
using Sistema_Gestor_Eventos_Tlahuac.Models;

namespace Sistema_Gestor_Eventos_Tlahuac.Controllers.Catalogos
{
    public class ParentescosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParentescosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parentescoes
        public async Task<IActionResult> Index(string search)
        {
            var parentescos = _context.Parentescos.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search)) {
                parentescos = parentescos.Where(p => p.Nombre.ToLower().Contains(search.ToLower()));
            }
            return View(await parentescos.ToListAsync());
        }

    // GET: Parentescoes/Details/5
    public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentescos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentesco == null)
            {
                return NotFound();
            }

            return View(parentesco);
        }

        // GET: Parentescoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parentescoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Activo")] Parentesco parentesco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parentesco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parentesco);
        }

        // GET: Parentescoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentescos.FindAsync(id);
            if (parentesco == null)
            {
                return NotFound();
            }
            return View(parentesco);
        }

        // POST: Parentescoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Activo")] Parentesco parentesco)
        {
            if (id != parentesco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parentesco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentescoExists(parentesco.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parentesco);
        }

        // GET: Parentescoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parentesco = await _context.Parentescos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parentesco == null)
            {
                return NotFound();
            }

            return View(parentesco);
        }

        // POST: Parentescoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parentesco = await _context.Parentescos.FindAsync(id);
            if (parentesco != null)
            {
                _context.Parentescos.Remove(parentesco);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentescoExists(int id)
        {
            return _context.Parentescos.Any(e => e.Id == id);
        }
    }
}
