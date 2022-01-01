using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        private const string noMatches = "No matches";
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = String.Empty;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] parts = input.Split(' ');
                string command = parts[0];

                if (command == "exchange")
                {
                    int index = int.Parse(parts[1]);
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = Exchange(index, numbers);
                    }
                }
                else if (command == "max" || command == "min")
                {
                    string evenOrOdd = parts[1];
                    Console.WriteLine(EvenOrOddMaxMin(numbers, command, evenOrOdd));
                }
                else if (command == "first" || command == "last")
                {
                    int numberCount = int.Parse(parts[1]);
                    string type = parts[2];

                    if (numberCount < 0 || numberCount > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine('[' + FirstOrLast(EvenOdd(numbers,type), command, numberCount) + ']');
                    }
                }
            }



            Console.Write('[');
            Console.Write(string.Join(", ", numbers));
            Console.Write(']');
        }

        static int[] EvenOdd(int[] arr, string evenOdd)
        {
            int[] evenOrOdd = new int[arr.Length];
            int index = 0;

            int resultFromModDiv = 0;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    evenOrOdd[index] = arr[i];
                    index++;
                }
            }

            arr = new int[index];
            Array.Copy(evenOrOdd, arr, index);

            return arr;
        }
        static string FirstOrLast(int[] arr, string firstOrLast, int count)
        {
            int[] newArray = new int[arr.Length];
            int indexCounter = 0;

            if (firstOrLast == "first")
            {
                for (int i = 0; i < count && i < arr.Length; i++)
                {
                    newArray[indexCounter] = arr[i];
                    indexCounter++;
                }
            }
            else if (firstOrLast == "last")
            {
                if (count > arr.Length)
                {
                    count = arr.Length;
                }

                for (int i = arr.Length - count; i < arr.Length; i++)
                {
                    newArray[indexCounter] = arr[i];
                    indexCounter++;
                }
            }

            arr = new int[indexCounter];

            Array.Copy(newArray, arr, indexCounter);

            return string.Join(", ", arr);
        }
        static string EvenOrOddMaxMin(int[] arr, string command, string evenOdd)
        {
            int indexCounter = -1;
            int max = int.MinValue;
            int min = int.MaxValue;

            int resultFromModDiv;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }
            else
            {
                resultFromModDiv = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    if (command == "min")
                    {
                        if (arr[i] <= min)
                        {
                            indexCounter = i;
                            min = arr[i];
                        }
                    }
                    else if (command == "max")
                    {
                        if (arr[i] >= max)
                        {
                            indexCounter = i;
                            max = arr[i];
                        }
                    }
                }
            }

            //if index is 0 and bigger than it 
            if (indexCounter >= 0)
            {
                return indexCounter.ToString();
            }
            // else its negative and there is no match in the sequence
            else
            {
                return "No matches";
            }
        }

        private static int[] Exchange(int index, int[] numbers)
        {
            //Creating a empty array where to assert changed numbers
            int[] newArray = new int[numbers.Length];
            int indexCounter = 0;

            //First numbers are from the next from split point (index) to the end
            for (int i = index + 1; i < numbers.Length; i++)
            {
                newArray[indexCounter] = numbers[i];
                indexCounter++;
            }
            //Than we add the last few left numbers
            for (int i = 0; i <= index; i++)
            {
                newArray[indexCounter] = numbers[i];
                indexCounter++;
            }

            return newArray;
        }
    }
}
