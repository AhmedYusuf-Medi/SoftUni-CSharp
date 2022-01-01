using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split(" -> ");
                string name = arg[0];
                string employe = arg[1];

                List<string> employes = new List<string> { employe };

                if (companies.ContainsKey(name))
                {                   
                    if (!companies[name].Contains(employe))
                    {
                        companies[name].Add(employe);
                    }
                }
                else
                {
                    companies.Add(name, employes);
                }
            }
            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employe in item.Value)
                {
                    Console.WriteLine($"-- {employe}");
                }
            }
        }
    }
}
