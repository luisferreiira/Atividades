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

            Matriz.gerarMatriz(matriz);
            Matriz.mostrarMatriz(matriz);

            diagonal_secundaria = Matriz.obterDiagonalSecundaria(matriz);

            Console.WriteLine("Diagonal Secundária: ");
            Vetor.printArray(diagonal_secundaria);
            

        }
    }
}
