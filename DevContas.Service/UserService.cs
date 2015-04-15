using DevContas.Domain;
using DevContas.Domain.Contracts.Repositories;
using DevContas.Domain.Contracts.Services;
using DevContas.Domain.Validation.Contracts;
using System;
using System.Collections.Generic;

namespace DevContas.Service
{
    public class UserService : IUserService
    {
        private IValidator<User> _userValidator;
        private IUserRepository _userRepository;
        private Dictionary<string, string> _errors;

        public UserService(IValidator<User> userValidator, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _userValidator = userValidator;
            _errors = new Dictionary<string, string>();
        }

        public void ChangeName(Guid id, string name)
        {
            var user = _userRepository.Get(id);
            user.ChangeName(name);
            _userRepository.Update(user);
        }

        public void Create(string name)
        {
            User user = new User(name);
            bool isValid = user.Validate(_userValidator, out _errors);

            if (isValid)
                _userRepository.Save(user);
        }

        public List<User> GetAll()
        {
            return _userRepository.Get();
        }

        public Dictionary<string, string> GetErrors()
        {
            return _errors;
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
