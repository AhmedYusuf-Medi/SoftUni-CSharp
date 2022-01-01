using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Rebel : IRebel
    {
        private int food;
        public Rebel(string name,int age,string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public string Name
        {
            get;
            private set;
        }

        public int Age
        {
            get;
            private set;
        }
        public string Group
        {
            get;
            private set;
        }

        public int Food => this.food;

        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
