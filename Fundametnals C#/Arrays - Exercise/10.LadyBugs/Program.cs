using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] ladyBugsIndexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            FillFieldWithZeroz(field);

            PlaceLadyBugsOnTheField(field, ladyBugsIndexes);

            string command = String.Empty;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] arg = command.Split();

                int currBugIndex = int.Parse(arg[0]);
                string direction = arg[1];
                int flyLenght = int.Parse(arg[2]);

                if (currBugIndex < 0 || currBugIndex >= field.Length || field[currBugIndex] == 0)
                {
                    continue;
                }


                field[currBugIndex] = 0;

                while (true)
                {
                    if (direction.ToLower() == "right")
                    {
                        currBugIndex += flyLenght;
                    }
                    else
                    {
                        currBugIndex -= flyLenght;
                    }

                    if (currBugIndex >= field.Length || currBugIndex < 0)
                    {
                        break;
                    }
                    if (field[currBugIndex] != 1)
                    {
                        field[currBugIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', field));
        }

        private static void PlaceLadyBugsOnTheField(int[] field, int[] ladyBugsIndexes)
        {
            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                int ladyBugIndex = ladyBugsIndexes[i];
                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                    field[ladyBugIndex] = 1;
                
            }
        }

        private static void FillFieldWithZeroz(int[] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = 0;
            }
        }
    }
}
