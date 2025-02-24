//Skaičių formatavimas valiutos stiliumi
//Parašykite programą, kuri prašo vartotojo įvesti realųjį skaičių (pvz., kainą) ir išveda jį valiutos formatu su € simboliu bei dviem skaičiais po kablelio.
//Pvz.:
//Įvedama: 5.20
//Rezultatas: "Kaina: 5.20 €"

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Give the price: ");
double.TryParse(Console.ReadLine(), out double price );
Console.WriteLine($"The price is: {(Math.Round(price, 2)).ToString("F2")}");