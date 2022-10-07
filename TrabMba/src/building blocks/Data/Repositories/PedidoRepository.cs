using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PedidoRepository : IRepository<PedidoEntities>

    {
        private readonly DataContext data;

        public PedidoRepository(DataContext Data)
        {
            Data = data;
        }
        public void Adcionar(PedidoEntities t)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(PedidoEntities t)
        {
            throw new NotImplementedException();
        }     

        public Task<PedidoEntities> ObterPorEmailSenha(PedidoEntities t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PedidoEntities>> ObterTodos()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
