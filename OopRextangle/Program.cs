//Užduotis:
//Sukurkite klasę Rectangle, kuri turės savybes Width ir Height.
//Sukurkite metodą GetArea(), kuris grąžina stačiakampio plotą.
//Sukurkite objektą ir išveskite jo plotą į konsolę.

using OopRectangle.Models;

namespace OopRectangle
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

        }
    }
}