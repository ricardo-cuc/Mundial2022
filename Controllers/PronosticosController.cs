using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mundial2022.Entidades;
using Mundial2022.Modelos;
using System;
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

        [HttpGet]
        public IActionResult Index(Usuario usuario)
        {
            return View(usuario);
        }

        public IActionResult Crear(int Id)
        {
            PronosticoCreacionViewModel pronostico = new PronosticoCreacionViewModel();
            
            pronostico.UserId = Id;
            pronostico.FasesSelect = context.Fases.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            pronostico.GruposSelect = pronostico.Grupos.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            pronostico.partidos = context.Partidos.Include(e => e.CEquipo1Navigation).Include(e => e.CEquipo2Navigation);
            return View(pronostico);

        }

        [HttpPost]
        public IActionResult Crear(IFormCollection formCollection)
        {
            string uCodigo = "656";
            IEnumerable<string> numerosPartidos = formCollection["NroPartido"];
            IEnumerable<string> codigosEquipo1Partidos = formCollection["CEquipo1"];
            IEnumerable<string> golesEquipo1Partidos = formCollection["QGolesE1"];
            IEnumerable<string> golesEquipo2Partidos = formCollection["QGolesE2"];

            List<ApuestasUsuario> apuestas = new List<ApuestasUsuario>();
            for (int i = 0; i < numerosPartidos.Count(); i++)
            {
                apuestas.Add(new ApuestasUsuario
                {
                    NroApuetas = numerosPartidos.ToString().ElementAt(i),
                    NroPartido = int.Parse(numerosPartidos.ElementAt(i)),
                    UCodigo = uCodigo,
                    AResultadoE1 = int.Parse(golesEquipo1Partidos.ElementAt(i)),
                    AResultadoE2 = int.Parse(golesEquipo2Partidos.ElementAt(i))
                });
            }

            foreach (var apuesta in apuestas)
            {
                try
                {
                    context.ApuestasUsuarios.Add(apuesta);
                }
                catch (Exception ex)
                {
                    string exs = ex.ToString();
                }
            }
            context.SaveChanges();
            return Ok();
        }

    }
}
