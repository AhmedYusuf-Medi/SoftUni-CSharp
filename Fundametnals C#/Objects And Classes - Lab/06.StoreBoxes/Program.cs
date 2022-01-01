using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxs = new List<Box>();

            while (input != "end")
            {
                string[] text = input.Split();
                string serialNumber = text[0];
                string itemName = text[1];
                int itemQuantity = int.Parse(text[2]);
                double priceForABox = double.Parse(text[3]);

                double totalPrie = priceForABox * itemQuantity;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.PriceForABox = priceForABox;
                box.TotalPrice = totalPrie;

                boxs.Add(box);
                input = Console.ReadLine();
            }
            List<Box> sortedBox = boxs.OrderBy(boxes => boxes.TotalPrice).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForABox:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");

            }
        }
        class Box
        {
            public string SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForABox { get; set; }
            public double TotalPrice { get; set; }
        }
    }
}
