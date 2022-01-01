using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {


        
        public Person(string name , int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }


       //public List<Person> Peoples { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other) 
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return Age.CompareTo(other.Name);
            }

            if (Age.CompareTo(other.Age) !=0)
            {
                return Age.CompareTo(other.Age);
            }

            if (Town.CompareTo(other.Town) != 0)
            {
                return Town.CompareTo(other.Town);
            }

            return 0;
        }
    }
}
