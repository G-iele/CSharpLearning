//Unikalių Skaičių Išrinkimas
//Užduotis: Parašykite metodą GetUniqueNumbers(int[] numbers), kuris grąžina naują masyvą tik su unikaliomis reikšmėmis, pašalindamas pasikartojimus.
//Testiniai duomenys:
//Jei turime masyvą {1, 2, 3, 2, 4, 1, 5}, metodas turi grąžinti {1, 2, 3, 4, 5}.


namespace FunctionUniqueNumbers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give the length of an array: ");
            int.TryParse(Console.ReadLine(), out int arrayLength);

            int[] givenArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Insert the value for index {i}: ");
                givenArray[i] = int.Parse(Console.ReadLine());
            }

          
            int[] uniqueValues = FilterUniqueValues(givenArray, arrayLength);
            for (int i = 0; i < uniqueValues.Length; i++)
            {
                Console.WriteLine(uniqueValues[i]);
            }
        }

        public static int[] FilterUniqueValues(int[] givenArray, int arrayLength)
        {
            int[] uniqueValuesArray = new int[arrayLength];
            int uniqueCount = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (uniqueValuesArray[j] == givenArray[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    uniqueValuesArray[uniqueCount] = givenArray[i];
                    uniqueCount++;
                }
            }

            int[] result = new int[uniqueCount];

            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = uniqueValuesArray[i];
            }

            return result;
        }

    }
}