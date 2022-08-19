using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Models;
using Microsoft.AspNetCore.Http;

namespace Mundial2022.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly MundialClubesContext _context;

        public UsuariosController(MundialClubesContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

                var usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(m => m.UCodigo == id);
                if (usuario == null)
                {
                    return NotFound();
                }

                return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string _UCorreo, string _UPassword)
        {
            try
            {
                ValidarUsuario validar = ValidarUsuario();
                Usuario db = new Usuario();
                Usuario oUsuario = (from d in db.Usuarios
                                where d.UCorreo == _UCorreo.Trim() && d.UPassword == _UPassword.Trim()
                                select d).FirstOrDefault();
                if (!ValidarUsuario())
                {
                    ViewBag.Error = "Usuario o contraseña no validos";
                    return View();
                }
                HttpContext.Session.SetString(_UCorreo,oUsuario.UCorreo);
                return RedirectToAction("Usuario", "Details");
            }
            catch
            {


            }
            return RedirectToAction("Usuario", "Details");


        }




        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UCodigo,UNombre,UApellido,UCorreo,UPassword,UPuntosTotales")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UCodigo,UNombre,UApellido,UCorreo,UPassword,UPuntosTotales")] Usuario usuario)
        {
            if (id != usuario.UCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UCodigo))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UCodigo == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(string id)
        {
            return _context.Usuarios.Any(e => e.UCodigo == id);
        }
        private bool ValidarUsuario (string _Ucorreo, string _UPassword)
        {
        
            return _context.Usuarios.Any(b => b.UCorreo == _Ucorreo && b.UPassword == _UPassword);
        }
    }
}
