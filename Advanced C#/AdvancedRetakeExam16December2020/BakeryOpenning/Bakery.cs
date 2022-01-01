using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;

        public int Capacity { get; set; }

        public string Name { get; set; }

        public int Count => this.employees.Count;

        public Bakery(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Employee employee)
        {
            if (employees.Count < Capacity)
            {
                this.employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = employees.FirstOrDefault(e => e.Name == name);
            if (employee == null)
            {
                return false;
            }

            employees.Remove(employee);
            return true;       
        }

        public Employee GetOldestEmploye()
        {
            Employee oldestEmploye = this.employees.OrderByDescending(e => e.Age).First();

            return oldestEmploye;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = this.employees.FirstOrDefault(e => e.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}");

            foreach (var employee in this.employees)
            {
                sb.Append($"{employee}");
            }

            return sb.ToString();
        }

    }
}
