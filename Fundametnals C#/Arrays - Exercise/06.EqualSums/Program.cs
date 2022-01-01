using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool done = false;
            int leftSum;
            int rightSum;
            for (int currNumber = 0; currNumber < arr.Length; currNumber++)
            {
                 rightSum = 0;
                
                for (int right = currNumber + 1; right < arr.Length; right++)
                {
                    rightSum += arr[right];
                }

                leftSum = 0;
                
                for (int left = currNumber - 1; left >= 0; left--)
                {
                    leftSum += arr[left];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(currNumber);
                    done = true;
                    break;
                }
            }
            if (!done)
            {
                Console.WriteLine("no");
            }
        }
    }
}
