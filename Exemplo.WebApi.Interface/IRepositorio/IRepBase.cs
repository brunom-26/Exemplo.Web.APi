using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.WebApi.Interface
{
    public interface IRepBase<T>
    {
        IList<T> Pesquisar();
        T BuscarPorId(int id);
        void Gravar(T item);
        void Bloquear(int id);
        void Desbloquear(int id);
    }
}
