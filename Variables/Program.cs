//Sukurti staciakampio ploto ir perimetro skaičiuoklę. Programa turi prašyti įvesti x ir y kraštines bei išvesti plotą ir perimetrą. (Su realiaisiais skaičiais) (edited) 
Console.WriteLine("Give the rectangle x value:");
int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Give the rectangle y value:");
int.TryParse(Console.ReadLine(), out int y);

Console.WriteLine($"The rectangle area size is: {x * y}");
Console.WriteLine($"The rectangle perimeter is: {(x + y) * 2}");

Console.WriteLine("\nCalculation is done");