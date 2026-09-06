/*9.
Você deve implementar um programa em C# que ajude o mago a calcular a força total das tropas de cada
região. Para isso, crie uma matriz de tamanho R x C, onde R representa o número de regiões (linhas) e C o número
de cidades (colunas) em cada região.
Cada elemento da matriz conterá o número total de tropas (guerreiros, arqueiros e magos) naquela cidade. Seu
programa deve fazer o seguinte:
1. Preencher a matriz com números aleatórios (representando o número de tropas em cada cidade), variando
de 0 a 100.
2. Exibir a matriz gerada (a quantidade de tropas em cada cidade).
3. Para cada linha (região), calcular e exibir a soma total das tropas da região.-9*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de regiões (linhas) da matriz: ");
            int linhas = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número de cidades (colunas) da matriz: ");
            int colunas = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[linhas, colunas];

            FuncoesMatriz.gerarMatriz(matriz);
            Console.WriteLine("Matriz das Tropas");
            FuncoesMatriz.mostrarMatriz(matriz);

            Console.WriteLine("Força Total por Região");
            FuncoesMatriz.mostrarMatriz(FuncoesMatriz.somarLinhas(matriz));

        }
    }
}