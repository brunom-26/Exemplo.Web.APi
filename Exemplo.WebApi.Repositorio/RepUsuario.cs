using Exemplo.WebApi.Interface.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.WebApi.Modelo;
using Exemplo.WebApi.Infraestrutura.Enum;

namespace Exemplo.WebApi.Repositorio
{
    public class RepUsuario : IRepUsuario
    {
        public void Bloquear(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            Grupo grupo = new Grupo("Teste");
            Usuario usuario = new Usuario("Teste Nome", "Login Teste", grupo);
            
            return usuario;
        }

        public void Desbloquear(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar(Usuario item)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> Pesquisar()
        {
            throw new NotImplementedException();
        }
    }
}
