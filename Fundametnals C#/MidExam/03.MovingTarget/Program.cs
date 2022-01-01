using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int >targets =Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] arg = text.Split();
                string comand = arg[0];
                int index = int.Parse(arg[1]);
                int dmgType = int.Parse(arg[2]);

                switch (comand)
                {
                    case "Shoot":
                        if (index < 0 || index >= targets.Count)
                        {
                            text = Console.ReadLine();

                            continue;
                        } 

                        targets[index] -= dmgType;

                        if (targets[index] <= 0)
                        {                  
                            targets.RemoveAt(index);
                        }
                       
                        break;
                    case "Add":
                        if (index < 0 || index >= targets.Count)
                        {
                            Console.WriteLine("Invalid placement!");

                            text = Console.ReadLine();

                            continue;
                        }
                        targets.Insert(index, dmgType);
                        break;
                    case "Strike":
                        int left = index - dmgType;
                        int right = index + dmgType;
                        if (left < 0 || right > targets.Count)
                        {
                            Console.WriteLine("Strike missed!");

                            text = Console.ReadLine();

                            continue;
                        }

                        for (int i = left; i < right; i++)
                        {
                            targets.RemoveAt(i);
                        }
                         break;
                    default:
                        Console.WriteLine("Osra nekude");
                        break;
                }
                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
