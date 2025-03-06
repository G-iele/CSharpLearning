using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPerson.Models
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
