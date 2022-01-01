using System;
using System.Linq;

namespace _05.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool big = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                for (int j =i + 1; j < arr.Length; j++)
                {
                    if (arr[j]>=current)
                    {
                        big = false;
                        break;
                    }   
                }
                if (big)
                {
                    Console.Write(current + " ");
                }
                big = true;
            }

        }
    }
}
