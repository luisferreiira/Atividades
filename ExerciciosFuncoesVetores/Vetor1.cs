using System;

class Vetor1
{
    static void Main()
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        Boolean estaNoVetor = false;

        Console.WriteLine("Insira um valor: ");
        int valorBuscado = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == valorBuscado)
            {
                estaNoVetor = true;
            }
        }

        if (estaNoVetor == true)
        {
            Console.WriteLine($"O valor {valorBuscado} está no vetor!");
        }
        else
        {
            Console.WriteLine("O valor não está dentro do vetor");
        }

    }
}