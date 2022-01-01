using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FistName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FistName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Excuse me but u are an ROBOT!");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Excuse me but u are still a Transofmer!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be accept if its negative or zero!");
                }
                this.age = value;
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Its a joke for a salary!");
                }
                this.salary = value;
            }
        }


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
            return $"{this.FistName} {this.LastName} gets {this.Salary:f2} leva.";
        }
    }
}
