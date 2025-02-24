//Studentų pažymių analizė
//Parašykite programą, kuri leidžia vartotojui įvesti 5 studentų pažymius (skaičius nuo 1 iki 10)
//ir išsaugo juos masyve. Programa turi atlikti šiuos veiksmus:
//Apskaičiuoti ir atspausdinti vidutinį pažymį.
//Surasti ir atspausdinti mažiausią bei didžiausią pažymį.
//Jei vidurkis mažesnis nei 5, išvesti pranešimą: „Grupės rezultatai prasti.“
//Jei vidurkis yra 5 ar didesnis, bet mažesnis nei 8, išvesti: „Vidutiniai rezultatai.“
//Jei vidurkis 8 ar didesnis, išvesti: „Puikūs rezultatai!“

namespace StudentsGrades
{
    public class Program
    {
        public static void Main()
        {
            int[] grades = new int[5];
            int student = 1;

            for(int i = 0; i < grades.Length; i++)
            {
            Console.WriteLine($"Insert {student++} student grade:");
            grades[i] = int.Parse(Console.ReadLine());
            }

            double average = GetAverage(grades);
            Console.WriteLine($"Average grade is: {average}");

            int minGrade = GetMin(grades);
            int maxGrade = GetMax(grades);

            Console.WriteLine($"The min grade of the group is: {minGrade}");
            Console.WriteLine($"The max grade of the group is: {maxGrade}");

            if(average < 5)
            {
                Console.WriteLine("Groups results is bad.");
            } else if (average >= 5 || average < 8)
            {
                Console.WriteLine("Groups results is average.");
            } else if (average >= 8)
            {
                Console.WriteLine("Groups results good.");
            }
        }

        public static double GetAverage(int[] grades)
        {
            int sum = 0;
            foreach(int num in grades){
                sum += num;
            }

            return sum / grades.Length;
        }

        public static int GetMin(int[] grades)
        {

            int result = grades[0];

            for(int i = 1; i < grades.Length; i++)
            {
                if (result > grades[i])
                {
                    result = grades[i];
                } 
            }

            return result;
        }

        public static int GetMax(int[] grades)
        {

            int result = grades[0];

            for (int i = 1; i < grades.Length; i++)
            {
                if (result < grades[i])
                {
                    result = grades[i];
                }
            }

            return result;
        }
    }
}