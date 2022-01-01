using System;
using System.Collections.Generic;
using System.Text;

namespace _06.StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
        public double TotalPrice { get; set; }
    }
}
