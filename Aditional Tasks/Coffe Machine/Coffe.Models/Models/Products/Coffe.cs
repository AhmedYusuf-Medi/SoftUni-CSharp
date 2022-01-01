using Coffee.Models.Contracts;
using Coffee.Models.Enumerators;

namespace Coffee.Models.Models.Products
{
    public class Coffee : Product, ICoffee
    {
        public Coffee(int id, string name, decimal price,
                     int quantity,Size size, CoffeeLevel level)
            : base(id, name, price, quantity,size)
        {
            this.Level = level;
        }

        public CoffeeLevel Level { get; private set; }
    }
}
