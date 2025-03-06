//Užduotis:
//Sukurkite klasę Person, kuri turės savybes Name ir Age.
//Sukurkite konstruktorių, kuris priima šias reikšmes kaip parametrus.
//Sukurkite objektą ir išveskite informaciją į ekraną.



using OopPerson.Models;

namespace OopPerson
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person("Laura", 20);
            person.PrintPerson();
        }
    }
}