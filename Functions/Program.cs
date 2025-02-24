//Sukurkite programą, kuri paprašytų vartotojo įvesti
//savaitės dienos numerį (1-7). Programa turi:
//Išvesti atitinkamą dienos pavadinimą (1 – Pirmadienis, 2 – Antradienis ir t. t.).
//Išvesti dienos vertinimą:
//Jei tai yra darbo diena (1-5), išvesti: „Darbo diena“.
//Jei tai savaitgalis (6-7), išvesti: „Savaitgalis! Pailsėk!“
//Reikalavimai:
//Naudokite funkciją GetDayName(int dayNumber), kuri grąžintų dienos pavadinimą
//kaip string.
//Naudokite switch, kad nustatyti dienos pavadinimą.
//Naudokite if, kad nustatyti, ar tai darbo diena, ar savaitgalis.

namespace Functions // reference to project name
{
    public class Program
    {
        public static void Main() // starts execution here
        {
            Console.WriteLine("Give a weekday number: ");
            int.TryParse(Console.ReadLine(), out int dayNumber);

            if (!IsValidDay(dayNumber))
            {
                Console.WriteLine("Given day is not valid. Program ended.");
                return;
            }

            Console.WriteLine(GetDayName(dayNumber));
            Console.WriteLine(GetDayType(dayNumber));
        }
        public static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "There is no such weekday.";
            }
        }
        public static string GetDayType (int dayNumber)
        {
            if(dayNumber >= 1 && dayNumber <= 5)
            {
                return "It is a work day.";
            } else
            {
                return "It is a weekend.";
            }
        }

        public static bool IsValidDay (int dayNumber)
        {
            return dayNumber >= 1 && dayNumber <= 7;
        }
    }
}
