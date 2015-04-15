using System.Collections.Generic;

namespace DevContas.Domain.Validation.Contracts
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
        Dictionary<string, string> Errors(T entity);
    }
}
