using System;
using Atividades.Biblioteca;

class Matriz01
{
    static void Main()
    {
        Console.Write("Digite o número de linhas da matriz: ");
        int linhas = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número de colunas da matriz: ");
        int colunas = int.Parse(Console.ReadLine()!);

        // declare a matriz
        int[,] matriz = new int[linhas,colunas];

        // Testando a função leia
        Console.WriteLine("\nDigite os elementos da matriz:");
        FuncoesMatriz.lerMatriz(matriz);

        Console.WriteLine("\nMatriz digitada:");
        FuncoesMatriz.mostrarMatriz(matriz);


        // Testando a função gera
        Console.WriteLine("\nGerando uma matriz com valores aleatórios...");
        FuncoesMatriz.gerarMatriz(matriz);
        Console.WriteLine("\nMatriz gerada aleatoriamente:");
        FuncoesMatriz.mostrarMatriz(matriz);

    }


}