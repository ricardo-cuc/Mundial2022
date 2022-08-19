using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Equipo
    {
        public Equipo()
        {
            EquiposCampeonatos = new HashSet<EquiposCampeonato>();
            JugEqCamps = new HashSet<JugEqCamp>();
            PartidoCEquipo1Navigations = new HashSet<Partido>();
            PartidoCEquipo2Navigations = new HashSet<Partido>();
        }

        public string CEquipo { get; set; }
        public string NEquipo { get; set; }
        public string ENombre { get; set; }

        public virtual ICollection<EquiposCampeonato> EquiposCampeonatos { get; set; }
        public virtual ICollection<JugEqCamp> JugEqCamps { get; set; }
        public virtual ICollection<Partido> PartidoCEquipo1Navigations { get; set; }
        public virtual ICollection<Partido> PartidoCEquipo2Navigations { get; set; }
    }
}
