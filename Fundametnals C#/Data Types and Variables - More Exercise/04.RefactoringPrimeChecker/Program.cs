using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //int loops = int.Parse(Console.ReadLine());
            //for (int takoa = 2; takoa <= loops; takoa++)
            //{
            //    bool takovalie = true;
            //    for (int cepitel = 2; cepitel < takoa; cepitel++)
            //    {
            //        if (takoa % cepitel == 0)
            //        {
            //            takovalie = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine("{0} -> {1}", takoa, takovalie);
            //}

            int number = int.Parse(Console.ReadLine());
            for (int startNumber = 2; startNumber <= number; startNumber++)
            {
                bool isPrime = true;
                for (int toCurrNum = 2; toCurrNum < startNumber; toCurrNum++)
                {
                    if (startNumber % toCurrNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", startNumber, isPrime.ToString().ToLower());
            }


        }
    }
}
