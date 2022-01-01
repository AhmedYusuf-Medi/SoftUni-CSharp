using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int numToRot = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    int currNum = arr[j];
                    arr[j - 1] = currNum;
                }
                arr[arr.Length - 1] = numToRot;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
