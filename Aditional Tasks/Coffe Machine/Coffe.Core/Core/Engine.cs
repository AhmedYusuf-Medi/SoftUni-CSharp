using Coffee.Core.Contracts;
using Coffee.Core.Core.Commands.Contracts;
using Coffee.Core.Core.Contracts;
using Coffee.Core.Core.Factories;
using Coffee.Core.Factories;
using Coffee.Core.Providers;
using System;
using System.Collections.Generic;

namespace Coffee.Core
{
    public class Engine : IEngine
    {
        public readonly int iD = 0;
        private const string TERMINATION_COMMAND = "exit";
        //private const string USER_NOT_LOGGED = "You are not logged! Please login first!";
        private const string REPORT_SEPARATOR = "####################";

        private readonly IProductFactory productFactory;
        private readonly IUserFactory userFactory;
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly CommandParser commandParser;
        private readonly Repository machineRepository;
        private readonly CommandFactory commandFactory;

        public Engine()
        {
            //productFactory = new ProductFactory();
            userFactory = new UserFactory();
            writer = new ConsoleWriter();
            reader = new ConsoleReader();
            commandParser = new CommandParser();
            machineRepository = new Repository();
            commandFactory = new CommandFactory();
        }

        public void Start()
        {

            while (true)
            {
                try
                {
                    string commandAsString = reader.ReadLine();
                    if (commandAsString == TERMINATION_COMMAND)
                    {
                        break;
                    }
                    processCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(!string.IsNullOrEmpty(ex.Message) ? ex.Message : ex.ToString());
                    writer.WriteLine(REPORT_SEPARATOR);
                }
            }
        }

        private void processCommand(string commandAsString)
        {
            if (commandAsString == null || commandAsString.Trim().Equals(""))
            {
                throw new ArgumentException("Command cannot be null or empty.");
            }

            string commandTypeAsString = commandParser.ParseCommand(commandAsString);
            List<string> parameters = commandParser.ParseParameters(commandAsString);
            ICommand command = commandFactory.CreateCommand(commandTypeAsString, productFactory,userFactory, machineRepository,parameters);
            string executionResult = command.Execute();
            writer.WriteLine(executionResult);
            writer.WriteLine(REPORT_SEPARATOR);

        }
    }
}
