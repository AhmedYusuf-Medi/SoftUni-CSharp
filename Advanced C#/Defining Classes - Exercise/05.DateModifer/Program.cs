using System;

namespace DefiningClasses

{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double res = DateModifer.GetDaysBetween(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(res);
        }
    }
}
