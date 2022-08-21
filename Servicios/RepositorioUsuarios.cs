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
        bool ObtenerUsuario(string nombreUsuario, string passUsuario);
    }
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly IConfiguration configuration;
        private readonly string URLApi;
        private readonly MundialClubesContext _context;


        public RepositorioUsuarios(MundialClubesContext context)
        {
            _context = context;
        }

        public bool ObtenerUsuario(string nombreUsuario, string passUsuario)
        {
            return  _context.Usuarios.Any(u => u.UCorreo == nombreUsuario && u.UPassword== passUsuario);
        }
    }
}
