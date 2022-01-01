using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student>students;

        public int Capacity { get; set; }

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }

        public int Count => this.students.Count;

        public string RegisterStudent(Student student)
        {
            if (this.students.Count < Capacity)
            {
                this.students.Add(student);

                return $"Added student {student.FirstName} {student.LastName}".ToString();
            }
            else
            {
                return" No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.students.
                FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student != null)
            {
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found"; 
            }
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(s => s.FirstName== firstName && s.LastName== lastName);

            return student;
        }

        public int GetStudentCount()
        {
            return this.Count;
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            if (this.students.Count < 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var student in students)
                {
                    if (student.Subject == subject)
                    {
                        sb.AppendLine($"{student.FirstName} {student.LastName}");
                    }
                    
                }

                return sb.ToString();
            }
        }



    }
}
