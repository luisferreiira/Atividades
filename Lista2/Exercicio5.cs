/*5. Crie uma função que receba uma matriz N por M e conte quantos números iguais a X existem na matriz. X
deve ser informado pelo usuário (parâmetro da função). Retorne a quantas ocorrências de X existem na
matriz.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio5
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[linhas, colunas];

            FuncoesMatriz.gerarMatriz(matriz);
            FuncoesMatriz.mostrarMatriz(matriz);

            Console.WriteLine("Insira um número inteiro para buscar na matriz: ");
            int numeroBuscado = int.Parse(Console.ReadLine()!);

            int ocorrenciasNumero = FuncoesMatriz.contarOcorrenciasNumero(matriz, numeroBuscado);

            Console.WriteLine($"{numeroBuscado} teve {ocorrenciasNumero} ocorrências ");         

        }
    }
}
