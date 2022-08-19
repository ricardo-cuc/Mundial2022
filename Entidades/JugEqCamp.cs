using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class JugEqCamp
    {
        public string CJugador { get; set; }
        public string CCampeonato { get; set; }
        public string CEquipo { get; set; }

        public virtual Campeonato CCampeonatoNavigation { get; set; }
        public virtual Equipo CEquipoNavigation { get; set; }
        public virtual Jugador CJugadorNavigation { get; set; }
    }
}
