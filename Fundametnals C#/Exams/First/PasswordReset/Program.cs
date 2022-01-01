using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {

        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                string[] arg = line.Split();

                string command = arg[0];
                
                if (command == "Done")
                {
                    Console.WriteLine($"Your password is: {password}");
                }

                if (command == "TakeOdd")
                {
                    StringBuilder newPassword = new StringBuilder();

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newPassword.Append(password[i]);
                        }
                    }

                    password = newPassword.ToString();
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(arg[1]);
                    int lenght = int.Parse(arg[2]);

                    password = password.Remove(index, lenght);

                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string toRemove = arg[1];
                    string toPut = arg[2];

                    bool doesPasswordContainsTheSubstring = password.Contains(toRemove);

                    if (doesPasswordContainsTheSubstring)
                    {
                        password = password.Replace(toRemove, toPut);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
        }
    }
}
