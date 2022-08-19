using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Models
{
    public partial class EquiposCampeonato
    {
        public int ECId { get; set; }
        public string CEquipo { get; set; }
        public string CCampeonato { get; set; }
        public int? ETotalPuntos { get; set; }

        public virtual Campeonato CCampeonatoNavigation { get; set; }
        public virtual Equipo CEquipoNavigation { get; set; }
    }
}
