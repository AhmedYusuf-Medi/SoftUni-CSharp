using Coffee.Core.Contracts;
using Coffee.Models.Contracts;
using Coffee.Models.Enumerators;
using Coffee.Models.Exceptions;
using System.Collections.Generic;

namespace Coffee.Core
{
    public class Repository : IRepository
    {
        private int id;

        private readonly IList<IUser> users;

        private readonly IList<ICoffee> coffees;

        //private readonly IList<IProduct> products;

        public Repository()
        {
            this.users = new List<IUser>();
            this.coffees = new List<ICoffee>();
            this.id = 0;
            //this.products = new List<IProduct>();
        }

        public void AddUser(IUser userToAdd)
        {
            if (!(users.Contains(userToAdd)))
            {
                users.Add(userToAdd);
            }
            throw new InvalidUserInputException("User is already added!");
        }

        public ICoffee CreateCoffe(string name, decimal price, int quantity, Size size,CoffeeLevel level)
        {
            var coffee = new Coffee.Models.Models.Products.Coffee(++id,name,price,quantity,size,level);
            return coffee;
        }
        //public IList<IProduct> Products => new List<IProduct>(this.products);
        public IList<ICoffee> Coffes => new List<ICoffee>(this.coffees);
        
        public ICoffee FindCoffeByName(Coffee.Models.Models.Products.Coffee coffeToCheck)
        {
            foreach (var coffee in this.coffees)
            {
                if (coffee.GetHashCode().Equals(coffeToCheck.GetHashCode()))
                {
                    return coffee;
                }
            }
            throw new EntityNotFoundException("Coffee doesn't exist!");
        }
        //public IUser Owner { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
