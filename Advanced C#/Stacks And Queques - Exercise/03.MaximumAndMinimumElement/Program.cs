using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 push
            //2 pop
            //3max
            //4 min
            int n = int.Parse(Console.ReadLine());

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = 
                    Console.ReadLine().
                    Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int arg = input[0];
                switch (arg)
                {
                    case 1:
                        result.Push(input[1]);
                        break;
                    case 2:
                        result.Pop();
                        break;
                    default:
                        break;
                }
                if (result.Count > 0)
                {
                    switch (arg)
                    {
                        case 3:
                            Console.WriteLine(result.Max());
                            break;
                        case 4:
                            Console.WriteLine(result.Min());
                            break;
                        default:
                            break;
                    }
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(", ",result));
            }
        }
    }
}
