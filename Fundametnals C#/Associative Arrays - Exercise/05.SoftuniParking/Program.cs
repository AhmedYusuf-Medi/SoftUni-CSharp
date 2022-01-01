using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string comand = input[0];
                string userName = input[1];

                if (comand == "register")
                {
                    string licensePlate = input[2];
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        users.Add(userName, licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                }
                if (comand == "unregister")
                {
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        users.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
