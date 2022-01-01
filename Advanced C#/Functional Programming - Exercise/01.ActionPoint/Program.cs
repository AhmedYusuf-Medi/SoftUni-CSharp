using System;

namespace FunctionalProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> printName = n => Console.WriteLine(string.Join(Environment.NewLine,n));

            printName(names);             
        }
    }
}
