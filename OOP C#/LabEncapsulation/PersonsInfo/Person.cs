using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {

        public Person(string firstName,string lastName,int age)
        {
            this.FistName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FistName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }


        public override string ToString()
        {
            return $"{this.FistName} {this.LastName} is {this.Age} years old."; 
        }
    }
}
