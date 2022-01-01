using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCountExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../words.txt");

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (!wordCounts.ContainsKey(lines[i]))
                {
                    wordCounts.Add(lines[i], 0);
                }
            }

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] wordsInLine = line.ToLower().Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }
                    , StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in lines)
                    {
                        foreach (var wordTxt in wordsInLine)
                        {
                            if (word == wordTxt)
                            {
                                wordCounts[word]++;
                            }
                        }
                    }

                }
            }

            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                foreach (var item in wordCounts.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}