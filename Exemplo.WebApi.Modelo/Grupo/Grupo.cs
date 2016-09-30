using Exemplo.WebApi.Infraestrutura.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Modelo
{
    public class Grupo : Base
    {
        public string Nome { get; set; }

        public Grupo(string nome)
        {
            Nome = nome;
            id = 1;
            DataInclusao = DateTime.Today;
            DataUltimaAlteracao = DateTime.Now;
            Status = EnumBaseStatus.Ativo;
        }
    }
}
