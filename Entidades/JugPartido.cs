using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class JugPartido
    {
        public string CJugador { get; set; }
        public int NroPartido { get; set; }
        public string NPosicion { get; set; }
        public int NroCamiseta { get; set; }
        public string FExpulsado { get; set; }
        public string FAmonestado { get; set; }
        public string FGoleador { get; set; }

        public virtual Jugador CJugadorNavigation { get; set; }
        public virtual Partido NroPartidoNavigation { get; set; }
    }
}
