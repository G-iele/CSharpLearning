//Maksimali Reikšmė Masyve
//Užduotis: Parašykite metodą FindMax(int[] numbers), kuris priima sveikųjų skaičių masyvą ir grąžina didžiausią masyvo reikšmę.
//Testiniai duomenys:
//Jei turime masyvą {3, 7, 2, 9, 5}, metodas turi grąžinti 9.

namespace ArrayMaxValue
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 3, 7, 2, 9, 5 };

            Console.WriteLine($"Max value: {FindMax(numbers)}");
        }

        public static int FindMax(int[] numbers)
        {
            int arrayLength = numbers.Length;
            int result = 0;

            for(int i = 0; i< arrayLength; i++)
            {
                if(result < numbers[i])
                {
                    result = numbers[i];
                }
            }

            return result;
        }
    }
}