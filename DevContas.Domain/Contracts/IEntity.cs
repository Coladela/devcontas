using DevContas.Domain.Validation.Contracts;
using System;
using System.Collections.Generic;

namespace DevContas.Domain.Contracts
{
    public interface IEntity<T>
    {
        Guid Id { get; }
        bool Validate(IValidator<T> validator, out Dictionary<string, string> errors);
    }
}
