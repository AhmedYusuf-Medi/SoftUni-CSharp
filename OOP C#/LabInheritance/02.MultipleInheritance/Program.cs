using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy yogi = new Puppy();
            yogi.Eat();
            yogi.Bark();
            yogi.Weep();
        }
    }
}
