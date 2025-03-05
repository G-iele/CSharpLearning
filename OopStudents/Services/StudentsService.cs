using OopStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudents.Services
{
    public class StudentsService
    {
        public Student GetStudent()
        {
            Student student = new Student();

            student.Name = GetString("Enter student's name: ");

            return student;
        }

        public string GetString(string message = "")
        {
            Console.Write(message);
            return Console.ReadLine() ?? "";
        }

        public void PrintStudents (List<Student> students)
        {
            Console.WriteLine("\nList of Students: ");
            foreach(Student s in students)
            {
                Console.WriteLine(s.GetFullName());
            }
        }
    }


}
