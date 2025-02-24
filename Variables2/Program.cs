// Parašykite programą kuri suskaičiuoja apskritimo ilgį, plotą ir skersmenį pagal apskritimo spindulį. Pi imkite 3.14
Console.WriteLine("Give the circle radius: ");
int.TryParse(Console.ReadLine(), out int r);

Console.WriteLine($"Circle diameter size: {r*2}");
Console.WriteLine($"Circle area size: {(Math.PI * r * r).ToString("F2")}");
Console.WriteLine($"Circle length: {(2*Math.PI * r).ToString("F2")}");
Console.WriteLine("\nProgram ends.");

