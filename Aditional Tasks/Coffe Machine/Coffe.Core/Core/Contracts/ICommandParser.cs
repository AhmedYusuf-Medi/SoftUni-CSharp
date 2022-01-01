using System.Collections.Generic;

namespace Coffee.Core.Contracts
{
    public interface ICommandParser
    {
        string ParseCommand(string fullCommand);
        List<string> ParseParameters(string fullCommand);
    }
}
