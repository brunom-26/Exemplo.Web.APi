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
            IList<Usuario> listUsuario = new List<Usuario>();
            Grupo grupo = new Grupo("Teste");
            Usuario usuario = new Usuario("Teste Nome", "Login Teste", grupo);

            Grupo grupo2 = new Grupo("Teste 2");
            Usuario usuario2 = new Usuario("Teste Nome 2", "Login Teste 2", grupo2);

            listUsuario.Add(usuario);
            listUsuario.Add(usuario2);

            return listUsuario;
        }
    }
}
