/*7.Crie uma função para calcular e apresentar a soma de 2 matrizes. *Verifique antes se elas são de mesma
ordem.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz A: ");
            int linhasA = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz A: ");
            int colunasA = int.Parse(Console.ReadLine()!);

            int[,] matrizA = new int[linhasA, colunasA];

            Console.Write("Digite o número de linhas da matriz B: ");
            int linhasB = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz B: ");
            int colunasB = int.Parse(Console.ReadLine()!);

            int[,] matrizB = new int[linhasB, colunasB];

            FuncoesMatriz.gerarMatriz(matrizA);
            FuncoesMatriz.gerarMatriz(matrizB);

            Console.WriteLine("Matriz A:");
            FuncoesMatriz.mostrarMatriz(matrizA);
            Console.WriteLine("Matriz B:");
            FuncoesMatriz.mostrarMatriz(matrizB);

            int[,] resultante = FuncoesMatriz.somarDuasMatrizes(matrizA, matrizB)!;
            if (resultante != null)
            {
                Console.WriteLine("Matriz A+B:");
                FuncoesMatriz.mostrarMatriz(resultante);
            }

        }
    }
}