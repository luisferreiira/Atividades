/*4. Escrever um programa que gere uma matriz de N Linhas x N Colunas e apresente sua diagonal secundária.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio4
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[linhas, colunas];

            int[] diagonal_secundaria = new int[linhas];

            FuncoesMatriz.gerarMatriz(matriz);
            FuncoesMatriz.mostrarMatriz(matriz);

            diagonal_secundaria = FuncoesMatriz.obterDiagonalSecundaria(matriz);

            Console.WriteLine("Diagonal Secundária: ");
            FuncoesArray.printArray(diagonal_secundaria);
            

        }
    }
}
