using Coffee.Core;
using Coffee.Core.Factories;

namespace Coffe.Core
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            var commandFactory = new CommandFactory();
            var engine = new Engine();
            engine.Start();
        }
    }
}
