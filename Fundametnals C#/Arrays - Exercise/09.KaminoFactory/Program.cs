using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            //Preparing output and placeholders for best result
            string[] bestDna =null;
            int bestLen = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;

            int currentSampleIndex = 0;

            string dna = String.Empty;
            while ((dna = Console.ReadLine().ToLower()) != "clone them!")
            {
                //Spliting input to array format
                string[] currentDna = dna.Split('!', StringSplitOptions.RemoveEmptyEntries);
                int currentLen = 0;
                int currentBestLen = 0;
                int currentEndIndex = 0;

                //Going through array and finding out best sequence
                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] == "1")
                    {
                        currentLen++;
                        if (currentLen > currentBestLen)
                        {
                            currentEndIndex = i;
                            currentBestLen = currentLen;
                        }
                    }
                    else
                    {
                        currentLen = 0;
                    }
                }

                //Getting start index
                int currentStartIndex = currentEndIndex - currentBestLen + 1;

                bool isCurrentDnaBetter = false;
                //Getting sum of the sequence
                int currentDnaSum = currentDna.Select(int.Parse).Sum();

                //if the current dna length is bigger than the best we reaplace it
                if (currentBestLen > bestLen)
                {
                    isCurrentDnaBetter = true;
                }
                //If they are equal ,first we compar current start index and the best
                //start index closer one to start is better dna
                //if  currentIndex is equal to bext start index we compare their sum the 
                //bigger sum is better dna
                else if (currentBestLen == bestLen)
                {
                    if (currentStartIndex < startIndex)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if (currentStartIndex == startIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            isCurrentDnaBetter = true;
                        }
                    }
                }

                //Counting wich line of input we are
                currentSampleIndex++;

                //Changing best parameter if we find better dna
                if (isCurrentDnaBetter)
                {
                    bestDna = currentDna;
                    bestLen = currentBestLen;
                    startIndex = currentStartIndex;
                    bestDnaSum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }
            }
            //outpu
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }

    }
}
