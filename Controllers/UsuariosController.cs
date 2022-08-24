using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Entidades;
using Mundial2022.Modelos;
using Mundial2022.Servicios;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mundial2022.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly MundialClubesContext _context;
        private readonly IRepositorioUsuarios repositorioUsuarios;

        public UsuariosController(MundialClubesContext context,
               IRepositorioUsuarios repositorioUsuarios
            )
        {
            _context = context;
            this.repositorioUsuarios = repositorioUsuarios;
        }

        // Metódo que llama a la vista vacia para realizar Login de un usuario
        public IActionResult Login()
        {
            ViewBag.Error = "";
            return View();
        }

        // Método que autentica si un usuario existe y sus credenciales son validas
        [HttpPost]
        public ActionResult Login(string _UCorreo, string _UPassword)
        {
            Usuario usuario = new Usuario();
            try
            {
                var existeUsuario = repositorioUsuarios.ExisteUsuario(_UCorreo, _UPassword);
                if (existeUsuario)
                {
                    usuario = repositorioUsuarios.ObtenerUsuario(_UCorreo);
                    UsuarioLogin usuarioLogin = new UsuarioLogin();
                    usuarioLogin.Id = int.Parse(usuario.UCodigo);
                    usuarioLogin.UNombre = usuario.UNombre;
                    return RedirectToAction("Index", "Usuarios", usuarioLogin);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                string strEx = ex.ToString();
                return RedirectToAction("Details", "Usuarios");
            }
        }
        // GET: Usuarios
        public IActionResult Index(UsuarioLogin usuarioLogin)
        {
            usuarioLogin.ApuestasUsuarios = repositorioUsuarios.ObtenerApuestas(usuarioLogin.Id.ToString());

            return View(usuarioLogin);
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

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            return RedirectToAction("Login", "Usuarios");
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

    }
}
