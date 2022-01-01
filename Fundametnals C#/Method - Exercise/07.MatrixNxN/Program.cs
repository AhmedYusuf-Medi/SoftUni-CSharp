using System;

namespace _07.MatrixNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            MatrixNxN(input);
        }

        private static void MatrixNxN(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
