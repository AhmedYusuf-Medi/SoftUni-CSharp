using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            
            // 1 Problem
            string output = spy.StealFieldInfo("Stealer.Hacker","username","password");

            Console.WriteLine(output);
            Console.WriteLine(new string('-',45));
            // 2 Problem
            output = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);

            Console.WriteLine(output);
            Console.WriteLine(new string('-',45));
            // 3 Problem
            output = spy.RevealPrivateMethods("Stealer.Hacker");

            Console.WriteLine(output);
            Console.WriteLine(new string('-', 45));

            // 4 Problem
            output = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(output);
        }
    }
}
