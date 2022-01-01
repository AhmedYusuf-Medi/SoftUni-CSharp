using Coffee.Core.Contracts;
using Coffee.Core.Core.Commands.Contracts;
using Coffee.Models.Enumerators;
using Coffee.Models.Errors;
using Coffee.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Coffee.Core.Core.Commands
{
    public abstract class BaseCommand : ICommand
    {
        protected BaseCommand(IRepository repository)
            : this(new List<string>(), repository)
        {
        }

        protected BaseCommand(IList<string> commandParameters, IRepository repository)
        {
            this.CommandParameters = commandParameters;
            this.Repository = repository;
        }

        protected IRepository Repository { get; }

        protected IList<string> CommandParameters { get; }

        protected void ParametersCountValidator(int countMustBe)
        {
            if (CommandParameters.Count != countMustBe)
            {
                throw new InvalidUserInputException($"Invalid number of arguments. Expected: {countMustBe}, Received: {CommandParameters.Count}");
            }
        }

        protected int ParseIntParameter(string value, string parameterName)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be an integer number.");
        }

        protected string ValidateStringParameter(string value, string parameterName)
        {
            Validator.CheckValueString(value, $"Invalid value for {parameterName}. Should be a real number.");

            return value;
        }

        protected double ParseDoubleParameter(string value, string parameterName)
        {
            if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }
            throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be a real number.");
        }

        protected decimal ParseDecimalParameter(string value, string parameterName)
        {
            if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal result))
            {
                return result;
            }
            throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be a real number.");
        }

        protected bool ParseBoolParameter(string value, string parameterName)
        {
            if (bool.TryParse(value, out bool result))
            {
                return result;
            }
            throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be either true or false.");
        }

        protected CoffeeLevel ParseCoffeLevelParamter(string value, string parameterName)
        {
            if (!Enum.TryParse(value, true, out CoffeeLevel result))
            {
                throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be CoffeeLevel type.");
            }
            return result;
        }

        protected Size ParseSizeParameter(string value, string parameterName)
        {
            if (!Enum.TryParse(value, true, out Size result))
            {
                throw new InvalidUserInputException($"Invalid value for {parameterName}. Should be Size type.");
            }
            return result;
        }

        public abstract string Execute();
    }

}
