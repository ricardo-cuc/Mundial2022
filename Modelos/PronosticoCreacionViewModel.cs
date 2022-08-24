using Microsoft.AspNetCore.Mvc.Rendering;
using Mundial2022.Entidades;
using System.Collections.Generic;

namespace Mundial2022.Modelos
{
    public class PronosticoCreacionViewModel
    {
        public int IdFase;
        public int IdGrupo;
        public IEnumerable<Fase> Fases = new List<Fase>() {
                new Fase
                {
                    Id=1,
                    Nombre="Fase de grupos"
                },
                new Fase
                {
                    Id=2,
                    Nombre="Octavos"
                },
                new Fase
                {
                    Id=3,
                    Nombre="Cuartos"
                },
                new Fase
                {
                    Id=4,
                    Nombre="Semifinal"
                },
                new Fase
                {
                    Id=5,
                    Nombre="Final"
                },
                new Fase
                {
                    Id=6,
                    Nombre="Fase de grupos 2"
                },
                                new Fase
                {
                    Id=7,
                    Nombre="Fase de grupos 3"
                }

             };

        public IEnumerable<Grupo> Grupos = new List<Grupo>() {
                new Grupo
                {
                    Id=1,
                    Nombre="A"
                },
                new Grupo
                {
                    Id=2,
                    Nombre="B"
                },
                new Grupo
                {
                    Id=3,
                    Nombre="C"
                },
                new Grupo
                {
                    Id=4,
                    Nombre="D"
                },
                new Grupo
                {
                    Id=5,
                    Nombre="E"
                },
                new Grupo
                {
                    Id=5,
                    Nombre="F"
                },
                new Grupo
                {
                    Id=5,
                    Nombre="G"
                },
                new Grupo
                {
                    Id=5,
                    Nombre="H"
                }
             };

        public IEnumerable<SelectListItem> FasesSelect { get; set; }
        public IEnumerable<SelectListItem> GruposSelect { get; set; }

        public IEnumerable<Partido> partidos = new List<Partido>();

        public int UserId { get; set; }
    }
}