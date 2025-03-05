
using OopStudents.Models;
using OopStudents.Services;

namespace OopStudents
{
    public class Program
    {
        public static void Main(string[] args)
        {

            StudentsService studentService = new StudentsService();
    

            List<Student> students = new List<Student>();

            bool continueAdding = true;

            while (continueAdding)
            {
                Student student = studentService.GetStudent();
                students.Add(student);
                Console.Write("Ar įvesite kitą studentą? (t/n): ");
                continueAdding = studentService.GetString().ToLower() == "t";
            }
            studentService.PrintStudents(students);
        }

    }
}