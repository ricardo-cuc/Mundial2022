using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Models
{
    public partial class Estadio
    {
        public Estadio()
        {
            Partidos = new HashSet<Partido>();
        }

        public string CEstadio { get; set; }
        public string NEstadio { get; set; }

        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
