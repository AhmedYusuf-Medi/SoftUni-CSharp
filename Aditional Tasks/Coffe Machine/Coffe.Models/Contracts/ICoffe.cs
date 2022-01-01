using Coffee.Models.Enumerators;

namespace Coffee.Models.Contracts
{
    public interface ICoffee : IProduct
    {
        CoffeeLevel Level { get; }         
    }
}
