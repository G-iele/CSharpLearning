//Temperatūros klasifikavimas
//Naudotojas įveda temperatūrą laipsniais Celsijaus. Programa turi nustatyti ir išvesti, ar temperatūra yra „Šalta“ (mažiau nei 10°C), „Vidutinė“ (nuo 10°C iki 25°C) ar „Karšta“ (daugiau nei 25°C).
Console.WriteLine("Write temperature: ");
int.TryParse(Console.ReadLine(), out int temp);

if (temp > 25)
{
    Console.WriteLine("Hot.");
}
else if (temp <= 25 && temp >= 15)
{
    Console.WriteLine("In the middle hot.");
} else if (temp < 15)
{
    Console.WriteLine("Cold.");
}