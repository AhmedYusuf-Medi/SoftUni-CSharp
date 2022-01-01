using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IIdentifiable> identifables = new Dictionary<string, IIdentifiable>();

            string line;
            while((line = Console.ReadLine()) != "End")
            {
                string[] arg = line.Split();

                if (arg.Length == 3)
                {
                    string name = arg[0];
                    int age = int.Parse(arg[1]);
                    string id = arg[2];

                    identifables[id] = new Citizen(name, age, id);
                }
                else
                {
                    string model = arg[0];
                    string id = arg[1];

                    identifables[id] = new Robot(model, id);
                }
            }
            string filtered = Console.ReadLine();

            var fakeIds = identifables.Where(i => i.Value.Id.EndsWith(filtered));

            foreach (var id in fakeIds)
            {
                Console.WriteLine(id.Value.Id);
            }
        }
    }
}
