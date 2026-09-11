/*1. Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o maior
valor da matriz.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[linhas, colunas];

            int maiorValor;

            Matriz.gerarMatriz(matriz);
            Matriz.mostrarMatriz(matriz);

            maiorValor = Matriz.obterMaiorValor(matriz);

            Console.WriteLine("Maior Valor da Matriz: " + maiorValor);

        }
    }
}