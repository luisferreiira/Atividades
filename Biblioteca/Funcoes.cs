using System;

class Funcoes
{
    public static void printArray(int[] vet, int n)
    {
        for(int i = 0; i < n; i++)
        {
            Console.Write(vet[i] + " | ");
        }
        Console.WriteLine();
    }

    public static void geraArray(int[] vet, int n)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vet[i] = rand.Next(1, 100);
        }
    }
}