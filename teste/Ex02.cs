using System;
class Ex02
{
    static void Main(string[] args)
    {
       double num1, num2, media;
       Console.WriteLine("Insira dois valores:");
       num1 = double.Parse(Console.ReadLine());
       num2 = double.Parse(Console.ReadLine());
       media = (num1 * 3.5 + num2 * 7.5) / 11;
       Console.WriteLine($"MEDIA = {media:F5}");
    }
}