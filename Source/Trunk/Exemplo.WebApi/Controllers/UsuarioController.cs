using Exemplo.WebApi.Interface.IServico;
using Exemplo.WebApi.Modelo;
using Exemplo.WebApi.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Exemplo.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        public Usuario Get(int id)
        {
            ISrvUsuario srvUsuario = new SrvUsuario();
            Usuario usuario = srvUsuario.BuscarPorId(id);

            return usuario;
        }
    }
}