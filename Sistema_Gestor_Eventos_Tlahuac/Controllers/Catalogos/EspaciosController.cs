using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Gestor_Eventos_Tlahuac.Data;
using Sistema_Gestor_Eventos_Tlahuac.Models.Catalogos;

namespace Sistema_Gestor_Eventos_Tlahuac.Controllers.Catalogos
{
    public class EspaciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EspaciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Espacios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Espacio.Include(e => e.Lugar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Espacios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacio = await _context.Espacio
                .Include(e => e.Lugar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (espacio == null)
            {
                return NotFound();
            }

            return View(espacio);
        }

        // GET: Espacios/Create
        public IActionResult Create()
        {
            ViewData["LugarId"] = new SelectList(_context.Lugares, "Id", "Nombre");
            return View();
        }

        // POST: Espacios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Capacidad,Activo,LugarId")] Espacio espacio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(espacio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LugarId"] = new SelectList(_context.Lugares, "Id", "Nombre", espacio.LugarId);
            return View(espacio);
        }

        // GET: Espacios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacio = await _context.Espacio.FindAsync(id);
            if (espacio == null)
            {
                return NotFound();
            }
            ViewData["LugarId"] = new SelectList(_context.Lugares, "Id", "Nombre", espacio.LugarId);
            return View(espacio);
        }

        // POST: Espacios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Capacidad,Activo,LugarId")] Espacio espacio)
        {
            if (id != espacio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(espacio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspacioExists(espacio.Id))
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
            ViewData["LugarId"] = new SelectList(_context.Lugares, "Id", "Nombre", espacio.LugarId);
            return View(espacio);
        }

        // GET: Espacios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var espacio = await _context.Espacio
                .Include(e => e.Lugar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (espacio == null)
            {
                return NotFound();
            }

            return View(espacio);
        }

        // POST: Espacios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var espacio = await _context.Espacio.FindAsync(id);
            if (espacio != null)
            {
                _context.Espacio.Remove(espacio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspacioExists(int id)
        {
            return _context.Espacio.Any(e => e.Id == id);
        }
    }
}
