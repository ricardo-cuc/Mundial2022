using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Models
{
    public partial class Jugador
    {
        public Jugador()
        {
            JugEqCamps = new HashSet<JugEqCamp>();
            JugPartidos = new HashSet<JugPartido>();
        }

        public string CJugador { get; set; }
        public string NJugador { get; set; }
        public DateTime? DNacimiento { get; set; }

        public virtual ICollection<JugEqCamp> JugEqCamps { get; set; }
        public virtual ICollection<JugPartido> JugPartidos { get; set; }
    }
}
