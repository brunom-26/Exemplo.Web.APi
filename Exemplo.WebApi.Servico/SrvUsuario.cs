using Exemplo.WebApi.Interface.IServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.WebApi.Modelo;
using Exemplo.WebApi.Interface.IRepositorio;
using Exemplo.WebApi.Repositorio;

namespace Exemplo.WebApi.Servico
{
    public class SrvUsuario : ISrvUsuario
    {
        IRepUsuario _repUsuario;

        public SrvUsuario() : this(new RepUsuario())
        {

        }

        protected SrvUsuario(IRepUsuario repUsuario)
        {
            _repUsuario = repUsuario;
        }

        public void Bloquear(int id)
        {
            _repUsuario.Bloquear(id);
        }

        public Usuario BuscarPorId(int id)
        {
            return _repUsuario.BuscarPorId(id);
        }

        public void Desbloquear(int id)
        {
            _repUsuario.Desbloquear(id);
        }

        public void Gravar(Usuario item)
        {
            _repUsuario.Gravar(item);
        }

        public IList<Usuario> Pesquisar()
        {
            return _repUsuario.Pesquisar();
        }
    }
}
