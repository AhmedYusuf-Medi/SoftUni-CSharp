using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                if (IsStudentExisting(students,firstName,lastName))
                {

                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = homeTown;

                }
                else
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = homeTown;
                    students.Add(student);
                }
 
                line = Console.ReadLine();

            }
            string filterCity = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.City == filterCity).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName ==  firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
