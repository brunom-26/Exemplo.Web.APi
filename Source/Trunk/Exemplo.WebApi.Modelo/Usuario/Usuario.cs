using Exemplo.WebApi.Infraestrutura.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Modelo
{
    public class Usuario : Base
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public Grupo Grupo { get; set; }

        public Usuario(string nome, string login, Grupo grupo)
        {
            id = 1;
            Nome = nome;
            Login = login;
            DataInclusao = DateTime.Today;
            DataUltimaAlteracao = DateTime.Now;
            Status = EnumBaseStatus.Ativo;
            Grupo = grupo;
        }

    }
}
