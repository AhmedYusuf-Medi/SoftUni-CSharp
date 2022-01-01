using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            seat.ToString();
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());

            tesla.ToString();
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());
        }
    }
}
