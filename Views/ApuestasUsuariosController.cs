using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Entidades;

namespace Mundial2022.Views
{
    public class ApuestasUsuariosController : Controller
    {
        private readonly MundialClubesContext _context;

        public ApuestasUsuariosController(MundialClubesContext context)
        {
            _context = context;
        }

        // GET: ApuestasUsuarios
        public async Task<IActionResult> Index()
        {
            var mundialClubesContext = _context.ApuestasUsuarios.Include(a => a.NroPartidoNavigation).Include(a => a.UCodigoNavigation);
            return View(await mundialClubesContext.ToListAsync());
        }

        // GET: ApuestasUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apuestasUsuario = await _context.ApuestasUsuarios
                .Include(a => a.NroPartidoNavigation)
                .Include(a => a.UCodigoNavigation)
                .FirstOrDefaultAsync(m => m.NroApuetas == id);
            if (apuestasUsuario == null)
            {
                return NotFound();
            }

            return View(apuestasUsuario);
        }

        // GET: ApuestasUsuarios/Create
        public IActionResult Create()
        {
            ViewData["NroPartido"] = new SelectList(_context.Partidos, "NroPartido", "NroPartido");
            ViewData["UCodigo"] = new SelectList(_context.Usuarios, "UCodigo", "UCodigo");
            return View();
        }

        // POST: ApuestasUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NroApuetas,NroPartido,UCodigo,ATipoResultado,AResultadoE1,APuntosCanjeados,AResultadoE2")] ApuestasUsuario apuestasUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apuestasUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NroPartido"] = new SelectList(_context.Partidos, "NroPartido", "NroPartido", apuestasUsuario.NroPartido);
            ViewData["UCodigo"] = new SelectList(_context.Usuarios, "UCodigo", "UCodigo", apuestasUsuario.UCodigo);
            return View(apuestasUsuario);
        }

        // GET: ApuestasUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apuestasUsuario = await _context.ApuestasUsuarios.FindAsync(id);
            if (apuestasUsuario == null)
            {
                return NotFound();
            }
            ViewData["NroPartido"] = new SelectList(_context.Partidos, "NroPartido", "NroPartido", apuestasUsuario.NroPartido);
            ViewData["UCodigo"] = new SelectList(_context.Usuarios, "UCodigo", "UCodigo", apuestasUsuario.UCodigo);
            return View(apuestasUsuario);
        }

        // POST: ApuestasUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NroApuetas,NroPartido,UCodigo,ATipoResultado,AResultadoE1,APuntosCanjeados,AResultadoE2")] ApuestasUsuario apuestasUsuario)
        {
            if (id != apuestasUsuario.NroApuetas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apuestasUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApuestasUsuarioExists(apuestasUsuario.NroApuetas))
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
            ViewData["NroPartido"] = new SelectList(_context.Partidos, "NroPartido", "NroPartido", apuestasUsuario.NroPartido);
            ViewData["UCodigo"] = new SelectList(_context.Usuarios, "UCodigo", "UCodigo", apuestasUsuario.UCodigo);
            return View(apuestasUsuario);
        }

        // GET: ApuestasUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apuestasUsuario = await _context.ApuestasUsuarios
                .Include(a => a.NroPartidoNavigation)
                .Include(a => a.UCodigoNavigation)
                .FirstOrDefaultAsync(m => m.NroApuetas == id);
            if (apuestasUsuario == null)
            {
                return NotFound();
            }

            return View(apuestasUsuario);
        }

        // POST: ApuestasUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apuestasUsuario = await _context.ApuestasUsuarios.FindAsync(id);
            _context.ApuestasUsuarios.Remove(apuestasUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApuestasUsuarioExists(int id)
        {
            return _context.ApuestasUsuarios.Any(e => e.NroApuetas == id);
        }
    }
}
