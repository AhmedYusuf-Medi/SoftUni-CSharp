using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double outFall = 39.99;
            double CSOG = 15.99;
            double zplinterZell = 19.99;
            double honored = 59.99;
            double roverWatch = 29.99;
            double roverWatchOE= 39.99;
            string tooExpensive = "Too Expensive";

            //OutFall 4
            //CS: OG
            //Zplinter Zell
            //Honored 2
            //RoverWatch
            //RoverWatch Origins Edition

            double money = double.Parse(Console.ReadLine());
            double remaining = money;
            string game = "";
            while (true)
            {
                game = Console.ReadLine();
                if (money == 0 || game == "Game Time")
                {
                    break;
                }

                switch (game)
                {
                    case "OutFall 4":
                        if (money < outFall)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= outFall;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        break;
                    case "CS: OG":
                        if (money < CSOG)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= CSOG;
                            Console.WriteLine("Bought CS: OG");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money < zplinterZell)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= zplinterZell;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        break;
                    case "Honored 2":
                        if (money < honored)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= honored;
                            Console.WriteLine("Bought Honored 2");
                        }
                        break;
                    case "RoverWatch":
                        if (money < roverWatch)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= roverWatch;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money < roverWatchOE)
                        {
                            Console.WriteLine(tooExpensive);
                        }
                        else
                        {
                            money -= roverWatchOE;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }

            remaining -= money;
            if (money == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${(remaining):f2}. Remaining: ${money:f2}");
            }
        }
    }
}
