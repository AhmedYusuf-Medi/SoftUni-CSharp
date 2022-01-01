using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] arg = line.Split();
                string type = arg[0];
                string id = arg[1];
                string firstName = arg[2];
                string lastName = arg[3];


                if (type == nameof(Private))
                {
                    decimal salary = decimal.Parse(arg[4]);
                    Soldier @private = new Private(id, firstName, lastName, salary);

                    soldiers[id]=(@private);
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    decimal salary = decimal.Parse(arg[4]);
                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral
                        (id, firstName, lastName, salary);

                    for (int i = 5; i < arg.Length; i++)
                    {
                        string privateId = arg[i];

                        if (!soldiers.ContainsKey(privateId))
                        {
                            continue;
                        }
                        lieutenantGeneral.AddPrivates((IPrivate)soldiers[privateId]);
                    }
                    soldiers[id] = lieutenantGeneral;
                }
                else if (type == nameof(Engineer))
                {
                    decimal salary = decimal.Parse(arg[4]);
                    bool isCorpsValid = Enum.TryParse(arg[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    Engineer enginer = new Engineer(id, firstName, lastName, salary,corps);

                    for (int i = 6; i < arg.Length; i+=2)
                    {
                        string part = arg[i];
                        int hoursWorked = int.Parse(arg[i + 1]);

                        Repair repair = new Repair(part, hoursWorked);

                        enginer.AddRepair(repair);
                    }

                    soldiers[id] = enginer;
                }
                else if (type == nameof(Commando))
                {
                    decimal salary = decimal.Parse(arg[4]);
                    bool isCorpsValid = Enum.TryParse(arg[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }

                    Commando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < arg.Length; i+=2)
                    {
                        string codeName = arg[i];
                        string state = arg[i + 1];

                        bool isMissionStateValid = Enum.TryParse(state, out MisionState misionState);

                        if (!isMissionStateValid)
                        {
                            continue;
                        }

                        Mission mission = new Mission(codeName, misionState);

                        commando.AddMission(mission);
                    }

                    soldiers[id] = commando;
                }
                else if (type == nameof(Spy))
                {
                    int codeNumber = int.Parse(arg[4]);

                    Spy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers[id] = spy;
                }
            }

            foreach (var soldier in soldiers.Values)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
