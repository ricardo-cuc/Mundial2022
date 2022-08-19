using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Entidades;

namespace Mundial2022.Controllers
{
    public class CampeonatoesController : Controller
    {
        private readonly MundialClubesContext _context;

        public CampeonatoesController(MundialClubesContext context)
        {
            _context = context;
        }

        // GET: Campeonatoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campeonatos.ToListAsync());
        }

        // GET: Campeonatoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonatos
                .FirstOrDefaultAsync(m => m.CCampeonato == id);
            if (campeonato == null)
            {
                return NotFound();
            }

            return View(campeonato);
        }

        // GET: Campeonatoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campeonatoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CCampeonato,NCampeonato,QPartidos")] Campeonato campeonato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campeonato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campeonato);
        }

        // GET: Campeonatoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonatos.FindAsync(id);
            if (campeonato == null)
            {
                return NotFound();
            }
            return View(campeonato);
        }

        // POST: Campeonatoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CCampeonato,NCampeonato,QPartidos")] Campeonato campeonato)
        {
            if (id != campeonato.CCampeonato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campeonato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampeonatoExists(campeonato.CCampeonato))
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
            return View(campeonato);
        }

        // GET: Campeonatoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonatos
                .FirstOrDefaultAsync(m => m.CCampeonato == id);
            if (campeonato == null)
            {
                return NotFound();
            }

            return View(campeonato);
        }

        // POST: Campeonatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var campeonato = await _context.Campeonatos.FindAsync(id);
            _context.Campeonatos.Remove(campeonato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampeonatoExists(string id)
        {
            return _context.Campeonatos.Any(e => e.CCampeonato == id);
        }
    }
}
