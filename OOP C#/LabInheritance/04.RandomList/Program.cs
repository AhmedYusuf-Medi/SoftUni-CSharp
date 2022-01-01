using System;

namespace CustomRandomList

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
