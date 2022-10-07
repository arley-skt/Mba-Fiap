using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IRepository <T>:IDisposable where T : class
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorEmailSenha(T t);
        void Adcionar(T t);
        void Atualizar(T t);
    }
}
