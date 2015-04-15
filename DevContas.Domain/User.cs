using DevContas.Domain.Contracts;
using DevContas.Domain.Validation.Contracts;
using System;
using System.Collections.Generic;

namespace DevContas.Domain
{
    public class User : IEntity<User>
    {
        protected User() { }
        public User(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public bool Validate(IValidator<User> validator, out Dictionary<string, string> errors)
        {
            errors = validator.Errors(this);
            return validator.IsValid(this);
        }
    }
}
