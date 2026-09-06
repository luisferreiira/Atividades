/*3. Escrever um programa que gere uma matriz de N Linhas x N Colunas e apresente sua diagonal principal.
Dica, limite sua matriz a uma ordem 100.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio3
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[linhas, colunas];

            int[] diagonal_principal = new int[linhas];

            FuncoesMatriz.gerarMatriz(matriz);
            FuncoesMatriz.mostrarMatriz(matriz);

            diagonal_principal = FuncoesMatriz.obterDiagonalPrincipal(matriz);

            Console.WriteLine("Diagonal Principal: ");
            FuncoesArray.printArray(diagonal_principal);
            

        }
    }
}