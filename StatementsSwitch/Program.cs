//Kalkuliatorius
//Naudotojas įveda du skaičius ir operacijos simbolį (+, -, *, /).
//Programa turi atlikti atitinkamą veiksmą su įvestais skaičiais ir
//išvesti rezultatą. Jei įvesta netinkama operacija,
//išvesti „Neteisinga operacija“.

double x = 0;
double y = 0;

try
{
    Console.WriteLine("Give first number: ");
    x = double.Parse(Console.ReadLine());

    Console.WriteLine("Give second number: ");
    y = double.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("The value is not a number type, program ended.");
    return;
}


Console.WriteLine("Choose the operator (+, -, *, /) : ");
char.TryParse(Console.ReadLine(), out char op);

switch (op)
{
    case '+':
        Console.WriteLine(x + y);
        break;
    case '-':
        Console.WriteLine(x - y);
        break;
    case '*':
        Console.WriteLine(x * y);
        break;
    case '/':
        if(y == 0)
        {
            Console.WriteLine("This operation is not possible, program ended.");
            return;
        }
        Console.WriteLine(x / y);
        break;
    default:
        Console.WriteLine("There is no such an operator.");
        break;
}

Console.WriteLine("\nCalculation done.");
