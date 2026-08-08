using System;

class AreaCirculo
{
    static void Main()
    {
        double raio,area;
        
        raio = double.Parse(Console.ReadLine()!);
        area = 3.14159 * Math.Pow(raio, 2);
        Console.WriteLine($"A={area:F4}");
    }
}