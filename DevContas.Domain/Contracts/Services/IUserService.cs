using System;
using System.Collections.Generic;

namespace DevContas.Domain.Contracts.Services
{
    public interface IUserService : IDisposable
    {
        Dictionary<string, string> GetErrors();
        void Create(string name);
        void ChangeName(Guid id, string name);
        List<User> GetAll();
    }
}
