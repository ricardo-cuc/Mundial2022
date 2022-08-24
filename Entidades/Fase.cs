using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Fase
    {
        public Fase()
        {
            Partidos = new HashSet<Partido>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
