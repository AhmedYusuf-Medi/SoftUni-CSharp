using Coffee.Models.Contracts;
using Coffee.Models.Enumerators;

namespace Coffee.Core.Contracts
{
    public interface IProductFactory
    {
        ICoffee CreateCoffe(string name, decimal price, int quantity, Size size);
    }
}
