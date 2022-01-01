using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {

        public Person(string firstName,string lastName,int age,decimal salary)
        {
            this.FistName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FistName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public decimal Salary { get; private set; }


        public void IncreaseSalary(decimal percantage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percantage / 100;
            }
            else
            {
                this.Salary += this.Salary * percantage / 200;
            }
        }


        public override string ToString()
        {
            return $"{this.FistName} {this.LastName} receives {this.Salary:f2} leva."; 
        }
    }
}
