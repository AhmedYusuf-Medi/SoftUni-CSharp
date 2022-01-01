using Coffee.Models.Contracts;
using Coffee.Models.Enumerators;
using System.Collections.Generic;

namespace Coffee.Core.Contracts
{
    public interface IRepository
    {
        //IList<IProduct> Products { get; }
        IList<ICoffee> Coffes { get; }
        //IUser Owner { get; set; }
        void AddUser(IUser userToAdd);
        ICoffee CreateCoffe(string name, decimal price, int quantity, Size size, CoffeeLevel level);
        ICoffee FindCoffeByName(Coffee.Models.Models.Products.Coffee coffeToCheck);
    }
}
