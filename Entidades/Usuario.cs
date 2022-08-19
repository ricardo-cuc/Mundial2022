using System;
using System.Collections.Generic;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class Usuario
    {
        public Usuario()
        {
            ApuestasUsuarios = new HashSet<ApuestasUsuario>();
        }

        public string UCodigo { get; set; }
        public string UNombre { get; set; }
        public string UApellido { get; set; }
        public string UCorreo { get; set; }
        public string UPassword { get; set; }
        public int? UPuntosTotales { get; set; }

        public virtual ICollection<ApuestasUsuario> ApuestasUsuarios { get; set; }
    }
}
