using Coffee.Models.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Contracts
{
    public interface IProduct : IHasId
    {
        string Name { get; }
        decimal Price { get; }
        int Quantity { get; }         
        Size Size { get; }
    }
}
