using DevContas.Domain.Validation.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DevContas.Domain.Validation
{
    public class UserValidator : IValidator<User>
    {
        public bool IsValid(User entity)
        {
            return Errors(entity).Count() == 0;
        }

        public Dictionary<string, string> Errors(User entity)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (entity.Id == null)
                result.Add("User.Id", "Identificador inválido");

            if (string.IsNullOrEmpty(entity.Name))
                result.Add("User.Name", "Nome inválido");

            return result;
        }
    }
}
