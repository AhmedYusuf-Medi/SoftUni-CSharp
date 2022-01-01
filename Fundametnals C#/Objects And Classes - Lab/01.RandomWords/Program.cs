using System;

namespace ObjectsAndClassesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < word.Length; i++)
            {
                int index = rnd.Next(word.Length);
                string firstWord = word[index];
                string secondWord = word[i];

                word[index] = secondWord;
                word[i] = firstWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine,word));
        }
    }
}
