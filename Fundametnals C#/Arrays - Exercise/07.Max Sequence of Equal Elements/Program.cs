using System;
using System.Linq;

namespace _07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestIndeex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNum == arr[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndeex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndeex]+" ");
            }
        }
    }
}
