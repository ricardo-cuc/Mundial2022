using Newtonsoft.Json;
using Mundial2022.Entidades;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System;
using System.Net.Http.Json;
using System.Linq;

namespace Mundial2022.Servicios
{
    public interface IRepositorioUsuarios
    {
        public bool ExisteUsuario(string nombreUsuario, string passUsuario);
        Usuario ObtenerUsuario(string nombreUsuario);
    }
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly MundialClubesContext _context;

        public RepositorioUsuarios(MundialClubesContext context)
        {
            _context = context;
        }

        public bool ExisteUsuario(string nombreUsuario, string passUsuario)
        {
            return _context.Usuarios.Any(u => u.UCorreo == nombreUsuario && u.UPassword == passUsuario);
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            return _context.Usuarios.Where(u => u.UCorreo == nombreUsuario).FirstOrDefault();
        }
    }
}
