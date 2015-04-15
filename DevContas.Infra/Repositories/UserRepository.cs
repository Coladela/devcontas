using DevContas.Domain;
using DevContas.Domain.Contracts.Repositories;
using DevContas.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevContas.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DevContasDataContext _db;

        public UserRepository(DevContasDataContext db)
        {
            _db = db;
        }

        public List<User> Get()
        {
            return _db.Users.OrderBy(x => x.Name).ToList();
        }

        public User Get(Guid id)
        {
            return _db.Users.Where(x => x.Id == id).First();
        }

        public void Delete(User user)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public void Save(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void Update(User user)
        {
            _db.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
