using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sequence of words: ");
            string[] seperatingStrings = new string[] { " ", ", " };
            string[] input = Console.ReadLine()
                .Split(seperatingStrings, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var array = Create(input);


            QuickSort(array, 0, array.Length - 1);

            Console.Write("Sorted variant of ur input: ");
            Console.WriteLine(string.Join(", ", array));
        }
        private static void QuickSort(string[] arr, int left, int right)
        {
            int leftS = left;//starting position
            int rightS = right;//end position

            string pivot = arr[(left + right) / 2];//middle

            while (leftS <= rightS)
            {
                while (arr[leftS].CompareTo(pivot) < 0)
                {
                    leftS++;
                }

                while (arr[rightS].CompareTo(pivot) > 0)
                {
                    rightS--;
                }

                if (leftS <= rightS)
                {
                    //swap
                    string currString = arr[leftS];
                    arr[leftS] = arr[rightS];
                    arr[rightS] = currString;

                    leftS++;
                    rightS--;
                }
            }

            if (left < rightS)
            {
                QuickSort(arr, left, rightS);
            }

            if (leftS < right)
            {
                QuickSort(arr, leftS, right);
            }
        }

        public static T[] Create<T>(T[] arr)
        {
            T[] itemArray = new T[arr.Length];

            for (int i = 0; i < itemArray.Length; i++)
            {
                itemArray[i] = arr[i];
            }
            return itemArray;
        }
    }
}
