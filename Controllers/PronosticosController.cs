using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Entidades;
using Mundial2022.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Mundial2022.Controllers
{
    public class PronosticosController : Controller
    {
        private readonly MundialClubesContext context;

        public PronosticosController(MundialClubesContext context)
        {
            this.context = context;
        }
        public IActionResult Crear()
        {
            PronosticoCreacionViewModel pronostico = new PronosticoCreacionViewModel();
            pronostico.FasesSelect = pronostico.Fases.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            pronostico.GruposSelect = pronostico.Grupos.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            pronostico.partidos = context.Partidos.Include(e => e.CEquipo1Navigation).Include(e => e.CEquipo2Navigation);
            return View(pronostico);

        }

    }
}
