using System;
using System.Linq;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] item1Data = Console.ReadLine().Split();
            string item1Name = item1Data[0] +" " +item1Data[1];
            string city = item1Data[2];

            CustomTuple<string, string> personInfo = new CustomTuple<string, string>(item1Name, city);

            string[] item2Data = Console.ReadLine().Split();
            string item2Name = item2Data[0];
            int literOfBeer =int.Parse(item2Data[1]);

            CustomTuple<string, int> nameAndBeerInfo = new CustomTuple<string, int>(item2Name, literOfBeer);

            string[] item3Data = Console.ReadLine().Split();

            int num = int.Parse(item3Data[0]);
            double doubleN = double.Parse(item3Data[1]);

            CustomTuple<int, double> nums = new CustomTuple<int, double>(num, doubleN);

            Console.WriteLine(personInfo);
            Console.WriteLine(nameAndBeerInfo);
            Console.WriteLine(nums);
        }
    }
}
