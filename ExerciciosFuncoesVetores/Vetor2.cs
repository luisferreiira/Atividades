using System;
using Atividades.Biblioteca;
//Faça um programa que leia um vetor X[10]. 
// Substitua a seguir, todos os valores nulos e negativos do vetor X por 1. 
// Em seguida mostre o vetor X.
class Vetor2
{
    static void Main()
    {
        int[] x = new int[10];

        for(int i = 0; i < 10; i++)
        {
            int valor = int.Parse(Console.ReadLine()!);

            if (valor <= 0)
                x[i] = 1;
            else
                x[i] = valor;  
        }

        for(int i = 0; i < 10; i++)
            Console.WriteLine($"x[{i}] = {x[i]}");   
    }
}