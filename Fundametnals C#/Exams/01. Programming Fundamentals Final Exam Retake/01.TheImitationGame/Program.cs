using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<string> output = new List<string>();

            for (int i = 0; i < message.Length; i++)
            {
                output.Add(message[i].ToString());
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] parts = input.Split('|');
                string command = parts[0];
                if (command == "ChangeAll")
                {
                    string letterToChange = parts[1];
                    string newLetter = parts[2];

                    for (int i = 0; i < output.Count; i++)
                    {
                        string currentLetter = output[i];
                        if (currentLetter == letterToChange)
                        {
                            output[i] = newLetter;
                        }
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(parts[1]);
                    string letterToInsert = parts[2];

                    for (int i = 0; i < letterToInsert.Length; i++)
                    {
                        output.Insert(index, letterToInsert[i].ToString());
                        index++;
                    }
                }
                else
                {
                    int numberOfLetters = int.Parse(parts[1]);
                    List<string> lettersToTake = new List<string>();
                    for (int i = 0; i < numberOfLetters; i++)
                    {
                        lettersToTake.Add(output[i]);
                    }
                    output.RemoveRange(0, numberOfLetters);

                    for (int i = 0; i < lettersToTake.Count; i++)
                    {
                        string currentLetter = lettersToTake[i];
                        output.Add(currentLetter);
                    }
                }
            }

            Console.WriteLine($"The decrypted message is: {string.Join("",output)}");
        }
    }
}
