using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class IUserRepository : IRepository<UserEntities>
    {

        private readonly DataContext data;

        public IUserRepository(DataContext Data)
        {
            Data = data;
        }
        public void Adcionar(UserEntities t)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(UserEntities t)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntities> ObterPorEmailSenha(UserEntities t)
        {
            return await data.Users.Where(w => w.email == t.email && w.senha == t.senha).FirstOrDefault();
        }

        public async Task<IEnumerable<UserEntities>> ObterTodos()
        {
            return await data.Users.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
