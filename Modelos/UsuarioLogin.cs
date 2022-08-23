using Mundial2022.Entidades;
using System.Collections.Generic;

namespace Mundial2022.Modelos
{
    public class UsuarioLogin
    {
        public UsuarioLogin()
        {
            ApuestasUsuarios = new HashSet<ApuestasUsuario>();
        }

        public int Id { get; set; }
        public string UNombre { get; set; }
        public string UApellido { get; set; }
        public string UCorreo { get; set; }
        public string UPassword { get; set; }
        public int? UPuntosTotales { get; set; }

        public virtual IEnumerable<ApuestasUsuario> ApuestasUsuarios { get; set; }
    }
}
