//Užduotis:
//Sukurkite klasę Car, kuri turės savybes Brand ir Year.
//Sukurkite objektą ir priskirkite jam reikšmes.
//Išveskite informaciją apie automobilį į konsolę.


using OopClassCar.Models;

namespace OopClassCar
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car("bmw", 2026);

            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Year);
        }

  
    }
}