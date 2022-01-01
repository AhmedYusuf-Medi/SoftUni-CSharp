using System;
using System.Collections.Generic;
using Coffee.Core.Contracts;
using Coffee.Core.Core.Commands.Contracts;
using Coffee.Core.Core.Contracts;
using Coffee.Core.Core.Enumerators;

namespace Coffee.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private const string INVALID_COMMAND = "Invalid command name: {0}!";

        public ICommand CreateCommand(string commandTypeAsString, IProductFactory dealershipFactory,IUserFactory userFactory, IRepository repository,List<string> parameters)
        {
            CommandType commandType = Enum.Parse<CommandType>(commandTypeAsString, true);
            switch (commandType)
            {
                case CommandType.CREATECLIENT:return null;
                //case CommandType.CREATEOWNER:return null;
                case CommandType.CREATECOFFEE:return new CreateCoffee(parameters,repository);
                case CommandType.CREATEPRODUCT:return null;
                case CommandType.LISTCOFFES: return null;
                case CommandType.LISTPRODUCTS: return null;
            }
            throw new ArgumentException(string.Format(INVALID_COMMAND, commandTypeAsString));
        }
    }
}
