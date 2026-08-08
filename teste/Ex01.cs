using System;

class Ex01
{
       static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        int a, b, soma;

        Console.WriteLine("Insira dois valores: ");
        a = int.Parse(Console.ReadLine()!);
        b = int.Parse(Console.ReadLine()!);
        soma = a + b;
        Console.WriteLine("X = " + soma);
    }
}