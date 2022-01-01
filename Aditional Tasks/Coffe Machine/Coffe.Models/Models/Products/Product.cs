using Coffee.Models.Constants.Messages;
using Coffee.Models.Contracts;
using Coffee.Models.Enumerators;
using Coffee.Models.Errors;
using Coffee.Models.Messages;
using System;

namespace Coffee.Models.Models.Products
{
    public abstract class Product : IProduct
    {
        protected bool IsInitialized = false;
        private string name;
        private decimal price;
        private int quantity;

        public Product(int id, string name,decimal price ,int quantity,Size size)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Id = id;
            this.Size = size;
        }
        public string Name
        {
            get => this.name;
            set
            {
                Validator.CheckValueString(value, ExceptionMessages.NameProperty);

                this.name = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                Validator.CheckIsNegativeOrZero(value, ExceptionMessages.PriceProperty);
                this.price = value;
            }
        }

        public int Quantity
        {
            get => this.quantity;
            set
            {
                Validator.CheckIsNegativeOrZero(value, ExceptionMessages.QuantityProperty);

                this.quantity = value;
            }
        }

        public Size Size { get; set; }
        public int Id { get; private set; }

        public override string ToString()
        {
            return String.Format(MethodAndCommandMessages.ProductToString,this.GetType().Name,this.Name,this.Price);
        }
    }
}
