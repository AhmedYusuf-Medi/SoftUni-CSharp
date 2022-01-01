using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBirthable> birthables = new Dictionary<string, IBirthable>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] arg = line.Split();
                string type = arg[0];

                if (type == nameof(Citizen))
                {
                    string name = arg[1];
                    int age = int.Parse(arg[2]);
                    string id = arg[3];
                    string birthdate = arg[4];

                    birthables[birthdate] = new Citizen(name, age, id,birthdate);
                }
                else if (type == nameof(Pet))
                {
                    string name = arg[1];
                    string birthdate = arg[2];

                    birthables[birthdate] = new Pet(name, birthdate);
                }
            }

            string filter = Console.ReadLine();
            var birtdatesAtThisYear = birthables.Where(b => b.Value.Birthdate.EndsWith(filter));

            foreach (var birthDate in birtdatesAtThisYear)
            {
                Console.WriteLine(birthDate.Value.Birthdate);
            }
        }
    }
}
