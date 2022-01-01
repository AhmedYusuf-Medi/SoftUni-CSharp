using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IPerson> clientsByName = new Dictionary<string, IPerson>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();
                string name = arg[0];
                int age = int.Parse(arg[1]);
                if (arg.Length == 4)
                {
                    string id = arg[2];
                    string birthdate = arg[3];

                    clientsByName[name] = new Citizen(name, age, id, birthdate);
                }
                else
                {
                    string group = arg[2];

                    clientsByName[name] = new Rebel(name, age, group);
                }
            }

            string line;

            while ((line = Console.ReadLine()) != "End")
            {
                if (clientsByName.ContainsKey(line))
                {
                    clientsByName[line].BuyFood();
                }
            }

            int sum = clientsByName.Sum(c => c.Value.Food);

            Console.WriteLine(sum);
        }
    }
}
