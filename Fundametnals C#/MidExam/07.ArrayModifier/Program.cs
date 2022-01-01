using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ArrayModifier
{
    class Program
    {
        private static int first;

        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().
                Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            string text = String.Empty;

            while ((text = Console.ReadLine()) != "end")
            {
                string[] arg = text.Split();
                string comand = arg[0];

                if (arg.Length == 3)
                {
                    int firstIndex = int.Parse(arg[1]);
                    int secondIndex = int.Parse(arg[2]);
                    int first = nums[firstIndex];
                    int second = nums[secondIndex];
                    switch (comand)
                    {
                        case "swap":
                            nums[firstIndex] = second;
                            nums[secondIndex] = first;
                            break;
                        case "multiply":
                            int result = first * second;
                            nums[firstIndex] = result;
                            break;
                    }
                }
                if (comand == "decrease")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums[i] -= 1;
                    }

                }
               
            }
            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
