using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mundial2022.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Mundial2022.Controllers
{
    public class PronosticosController : Controller
    {
        public IActionResult Crear()
        {
            PronosticoCreacionViewModel pronostico = new PronosticoCreacionViewModel();
            pronostico.FasesSelect = pronostico.Fases.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            pronostico.GruposSelect = pronostico.Grupos.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            return View(pronostico);

        }

    }
}
