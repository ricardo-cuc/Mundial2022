using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Partido
    {
        public Partido()
        {
            ApuestasUsuarios = new HashSet<ApuestasUsuario>();
            JugPartidos = new HashSet<JugPartido>();
        }

        public int NroPartido { get; set; }
        public string CEstadioPart { get; set; }
        public string CEquipo1 { get; set; }
        public string CEquipo2 { get; set; }
        public string CCampeonato { get; set; }
        public DateTime? DPartido { get; set; }
        public string NJuezLinea1 { get; set; }
        public string NJuezLinea2 { get; set; }
        public int? QGolesE1 { get; set; }
        public int? QGolesE2 { get; set; }
        public string NArbitro { get; set; }
        public string EPartido { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Campeonato CCampeonatoNavigation { get; set; }
        public virtual Equipo CEquipo1Navigation { get; set; }
        public virtual Equipo CEquipo2Navigation { get; set; }
        public virtual Estadio CEstadioPartNavigation { get; set; }
        public virtual ICollection<ApuestasUsuario> ApuestasUsuarios { get; set; }
        public virtual ICollection<JugPartido> JugPartidos { get; set; }
    }
}
