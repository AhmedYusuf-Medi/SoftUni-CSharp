using Coffee.Core.Contracts;
using Coffee.Core.Core.Commands.Contracts;
using Coffee.Core.Core.Contracts;
using System.Collections.Generic;

namespace Coffee.Core.Contracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandTypeAsString, IProductFactory dealershipFactory, IUserFactory userFactory, IRepository repository,List<string> parameters);
    }
}
