using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MathOperations(firstNum, @operator,secNum));
        }

        private static int MathOperations(int firstNum, char @operator, int secNum)
        {
            switch (@operator)
            {
                case '+':
                    return firstNum + secNum;
                case '-':
                    return firstNum - secNum;
                case '*':
                    return firstNum * secNum;
                case '/':
                    return firstNum / secNum;
                case '^':
                    return (int)Math.Pow(firstNum,secNum);
                case '%':
                    return firstNum % secNum;
                default:
                    throw new ArgumentException("Wrong operator!");
            }
        }
    }
}
