//using System;

//Atvirkštinis Masyvas
//Užduotis: Parašykite metodą ReverseArray(int[] numbers), kuris priima sveikųjų skaičių masyvą
//ir grąžina naują masyvą su reikšmėmis atvirkštine tvarka.
//Testiniai duomenys:
//Jei turime masyvą {1, 2, 3, 4, 5}, metodas turi grąžinti {5, 4, 3, 2, 1}.

namespace ArrayReverse
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };



            Console.Write($"Reversed array: {string.Join(", ", ReverseArray(numbers))}");
        }

        public static int[] ReverseArray(int[] numbers)
        {
            int arrayLength = numbers.Length;
            int index = 0;
            int[] reversedArray = new int[numbers.Length];
            
            for(int i = arrayLength-1; i >= 0; i--)
            {
                reversedArray[index] = numbers[i];
                index++;
            }

            return reversedArray;
        }
    }
 }