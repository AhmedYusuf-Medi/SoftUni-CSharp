using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Threeuple
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] item1Data = Console.ReadLine().Split();
            string fullName = item1Data[0] +" " +item1Data[1];
            string adress = item1Data[2];
            List<string> townData = item1Data.ToList().Skip(3).ToList();
            string town = string.Join(" ", townData);

            Threeuple<string, string, string> personInfo =
                new Threeuple<string, string, string>(fullName, adress, town);

            string[] item2Data = Console.ReadLine().Split();
            string item2Name = item2Data[0];
            int litterOfBeer = int.Parse(item2Data[1]);
            bool drunkOrNot = item2Data[2] ==  "drunk" ? true:false;
            //if (item2Data[2] == "drunk")
            //{
            //    drunkOrNot = true;
            //}

            Threeuple<string, int, bool> alcholic =
                new Threeuple<string, int, bool>(item2Name, litterOfBeer, drunkOrNot);

            string[] item3Data = Console.ReadLine().Split();
            string item3Name = item3Data[0];
            double accountBalance = double.Parse(item3Data[1]);
            string bankName = item3Data[2];

            Threeuple<string, double, string> bankInfo
                = new Threeuple<string, double, string>(item3Name, accountBalance, bankName);


            Console.WriteLine(personInfo);
            Console.WriteLine(alcholic);
            Console.WriteLine(bankInfo);
        }
    }
}
