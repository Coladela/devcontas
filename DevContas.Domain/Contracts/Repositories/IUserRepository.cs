using System;
using System.Collections.Generic;

namespace DevContas.Domain.Contracts.Repositories
{
    public interface IUserRepository : IDisposable
    {
        List<User> Get();
        User Get(Guid id);
        void Save(User user);
        void Update(User user);
        void Delete(User user);
    }
}
