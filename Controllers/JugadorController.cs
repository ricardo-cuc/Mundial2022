using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Models;

namespace Mundial2022.Controllers
{
    public class JugadorController : Controller
    {
        private readonly MundialClubesContext _context;

        public JugadorController(MundialClubesContext context)
        {
            _context = context;
        }

        // GET: Jugador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jugadors.ToListAsync());
        }

        // GET: Jugador/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadors
                .FirstOrDefaultAsync(m => m.CJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // GET: Jugador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jugador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CJugador,NJugador,DNacimiento")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jugador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jugador);
        }

        // GET: Jugador/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadors.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }
            return View(jugador);
        }

        // POST: Jugador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CJugador,NJugador,DNacimiento")] Jugador jugador)
        {
            if (id != jugador.CJugador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jugador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugadorExists(jugador.CJugador))
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
            return View(jugador);
        }

        // GET: Jugador/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadors
                .FirstOrDefaultAsync(m => m.CJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // POST: Jugador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var jugador = await _context.Jugadors.FindAsync(id);
            _context.Jugadors.Remove(jugador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugadorExists(string id)
        {
            return _context.Jugadors.Any(e => e.CJugador == id);
        }
    }
}
