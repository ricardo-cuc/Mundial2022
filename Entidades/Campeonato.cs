using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Campeonato
    {
        public Campeonato()
        {
            EquiposCampeonatos = new HashSet<EquiposCampeonato>();
            JugEqCamps = new HashSet<JugEqCamp>();
            Partidos = new HashSet<Partido>();
        }

        public string CCampeonato { get; set; }
        public string NCampeonato { get; set; }
        public int? QPartidos { get; set; }

        public virtual ICollection<EquiposCampeonato> EquiposCampeonatos { get; set; }
        public virtual ICollection<JugEqCamp> JugEqCamps { get; set; }
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
