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
    public class TipoActividadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoActividadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoActividades
        public async Task<IActionResult> Index(string search)
        {
            var tipoactividad = _context.TiposActividades.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search))
            {
                tipoactividad = tipoactividad.Where(c => c.Nombre.ToLower().Contains(search.ToLower()));
            }
            return View(await tipoactividad.ToListAsync());
        }

        // GET: TipoActividades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoActividad = await _context.TiposActividades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoActividad == null)
            {
                return NotFound();
            }

            return View(tipoActividad);
        }

        // GET: TipoActividades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoActividades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Activo")] TipoActividad tipoActividad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoActividad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoActividad);
        }

        // GET: TipoActividades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoActividad = await _context.TiposActividades.FindAsync(id);
            if (tipoActividad == null)
            {
                return NotFound();
            }
            return View(tipoActividad);
        }

        // POST: TipoActividades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Activo")] TipoActividad tipoActividad)
        {
            if (id != tipoActividad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoActividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoActividadExists(tipoActividad.Id))
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
            return View(tipoActividad);
        }

        // GET: TipoActividades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoActividad = await _context.TiposActividades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoActividad == null)
            {
                return NotFound();
            }

            return View(tipoActividad);
        }

        // POST: TipoActividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoActividad = await _context.TiposActividades.FindAsync(id);
            if (tipoActividad != null)
            {
                _context.TiposActividades.Remove(tipoActividad);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoActividadExists(int id)
        {
            return _context.TiposActividades.Any(e => e.Id == id);
        }
    }
}
