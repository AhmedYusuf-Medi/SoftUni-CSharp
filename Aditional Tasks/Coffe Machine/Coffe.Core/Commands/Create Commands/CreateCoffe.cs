using Coffee.Core.Contracts;
using System;
using System.Collections.Generic;
using Coffee.Models.Models.Products;
using Coffee.Models.Enumerators;
using System.Linq;
using Coffee.Models.Exceptions;

namespace Coffee.Core.Core.Commands.Contracts
{
    public class CreateCoffee : BaseCommand
    {
        private int ParametersCountMustBe = 5;
        public CreateCoffee(IList<string> commandParameters, IRepository repository)
            : base(commandParameters, repository)
        {
        }

        //(string name, decimal price, int quantity, Size size,CoffeeLevel level)
        public override string Execute()
        {
            this.ParametersCountValidator(ParametersCountMustBe);

            string name = this.CommandParameters[0];
            decimal price = this.ParseDecimalParameter(this.CommandParameters[1], "price");
            int quantity = this.ParseIntParameter(this.CommandParameters[2], "quantity");
            Size size = this.ParseSizeParameter(this.CommandParameters[3], "size");
            CoffeeLevel level = this.ParseCoffeLevelParamter(this.CommandParameters[4], "level");

            if (Repository.Coffes.Any(c => c.Name.ToLower() == name.ToLower()))
            {
                throw new InvalidUserInputException($"A coffee with the name {name} already exists!");
            }

            var coffee = this.Repository.CreateCoffe(name,price,quantity,size,level);

            return $"Succesfully created Coffee: {coffee}";
        }
    }

}
