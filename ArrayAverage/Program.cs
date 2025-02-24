//Vidurkio Skaičiavimas
//Užduotis: Parašykite metodą CalculateAverage(int[] numbers), kuris priima sveikųjų skaičių masyvą ir grąžina masyvo
//elementų vidurkį kaip double.
//Testiniai duomenys:
//Jei turime masyvą {10, 20, 30, 40, 50}, metodas turi grąžinti 30.0.

namespace ArrayAverage
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine($"Average: {  CalculateAverage(numbers).ToString("F1")}");
        }

        public static double CalculateAverage(int[] numbers)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }
    }
}