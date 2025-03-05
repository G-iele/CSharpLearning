using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudents.Models
{
    public class Student
    {
        public string? Name { get; set; }

        public string GetFullName()
        {
            return Name;
        }
    }
}
