using System;
using Atividades.Biblioteca;
//Faça um programa que leia um valor N. 
// Este N será o tamanho de um vetor X[N].
//  A seguir, leia cada um dos valores de X,
//   encontre o menor elemento deste vetor e 
//   a sua posição dentro do vetor, mostrando esta informação.
class Vetor3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        string linha = Console.ReadLine()!;
        string[] partes = linha.Split(' ');

        int[] x = new int[n];
        for (int i = 0; i < n; i++)
        {
            x[i] = int.Parse(partes[i]);
        }

        int menorValor = x[0];
        int posicaoMenorValor = 0;
        for(int i = 1; i < n; i++)
        {
            if(x[i] < menorValor)
            {
                menorValor = x[i];
                posicaoMenorValor = i;
            }
        }

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Posicao: {posicaoMenorValor}");
    }
}