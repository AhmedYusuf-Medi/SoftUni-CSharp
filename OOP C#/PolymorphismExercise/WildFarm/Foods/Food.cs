using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.FoodQuantity = quantity;
        }

        public int FoodQuantity { get; private set; }
    }
}
