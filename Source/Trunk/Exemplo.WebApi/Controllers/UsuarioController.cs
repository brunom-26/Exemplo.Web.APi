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
        //api/Usuario
        public IHttpActionResult Get()
        {
            try
            {
                ISrvUsuario srvUsuario = new SrvUsuario();
                IList<Usuario> usuarios = srvUsuario.Pesquisar();

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/Usuario/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ISrvUsuario srvUsuario = new SrvUsuario();
                Usuario usuario = srvUsuario.BuscarPorId(id);

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/Usuario/5
        public IHttpActionResult Put(Usuario usuario)
        {
            try
            {
                ISrvUsuario srvUsuario = new SrvUsuario();
                srvUsuario.Gravar(usuario);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/Usuario/Bloquear/5
        [HttpGet]
        [Route("api/Usuario/Bloquear/{id}")]
        public IHttpActionResult Bloquear(int id)
        {
            try
            {
                ISrvUsuario srvUsuario = new SrvUsuario();
                srvUsuario.Bloquear(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/Usuario/Desbloquear/5
        [HttpGet]
        [Route("api/Usuario/Desbloquear/{id}")]
        public IHttpActionResult Desbloquear(int id)
        {
            try
            {
                ISrvUsuario srvUsuario = new SrvUsuario();
                srvUsuario.Desbloquear(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

