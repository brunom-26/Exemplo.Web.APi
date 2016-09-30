using Exemplo.WebApi.Infraestrutura.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Modelo
{
    public abstract class Base
    {
        public int id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public EnumBaseStatus Status { get; set; }
    }
}
