using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Grupo
    {
        public Grupo()
        {
            Partidos = new HashSet<Partido>();
        }

        public int IdGrupo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
