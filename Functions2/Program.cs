//Sukurkite programą, kuri paprašytų vartotojo įvesti sveikąjį skaičių ir
//atliktų šias operacijas:
//Patikrintų, ar skaičius yra lyginis ar nelyginis.
//Apskaičiuotų skaitmenų sumą.
//Patikrintų, ar skaičius yra palindromas (pvz., 121, 1331 yra palindromai).
//Reikalavimai:
//Funkcija IsEven(int number) – grąžina true, jei skaičius yra lyginis,
//kitaip – false.
//Funkcija SumOfDigits(int number) – apskaičiuoja ir grąžina skaitmenų sumą.
//Funkcija IsPalindrome(int number) – patikrina, ar skaičius yra palindromas.
//(Neprivaloma, besidomintiems)
//Pagrindinė programa turi kviesti visas tris funkcijas ir išvesti rezultatus
//vartotojui.

namespace Functions2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write number: ");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine("Number is: " + (IsEven(num) ? "even." : "odd."));
            Console.WriteLine("The sum of digits is: " + SumOfDigits(num));
            Console.WriteLine("Number is: " + (IsPalindrome(num) ? "polindrome" : "is not polindrome"));
        }

        public static bool IsEven (int num)
        {
            return num % 2 == 0;
        }

        public static int SumOfDigits(int num)
        {
            int sum = 0;
            string numStringified = num.ToString();
           for (int i = 0; i < numStringified.Length; i++)
            {
                sum += numStringified[i];
            }
            return sum;
        }

        public static bool IsPalindrome (int num)
        {
            string numStringified = num.ToString();
            string reversedNum = "";
            for (int i = numStringified.Length-1; i >= 0; i--)
            {
                reversedNum += numStringified[i];
            }
            return reversedNum == numStringified;
        }
    }
}

//4.Studentų pažymių analizė
//Užduotis:
//Sukurkite programą, kuri leis vartotojui įvesti tris studento pažymius ir apskaičiuos:
//Vidutinį pažymį.
//Didžiausią pažymį.
//Mažiausią pažymį.
//Reikalavimai:
//Naudokite funkciją CalculateAverage(int a, int b, int c), kuri apskaičiuoja ir grąžina vidutinį pažymį.
//Naudokite funkciją FindMaxGrade(int a, int b, int c), kuri grąžina didžiausią pažymį.
//Naudokite funkciją FindMinGrade(int a, int b, int c), kuri grąžina mažiausią pažymį.
//Naudokite tik if, switch, įvedimą, išvedimą ir funkcijas.
//Negalima naudoti ciklų ar kolekcijų.
//Programa turi užtikrinti, kad vartotojas įvestų pažymius tarp 0 ir 10. Jei įvesta neteisinga reikšmė, turi būti prašoma įvesti iš naujo.

