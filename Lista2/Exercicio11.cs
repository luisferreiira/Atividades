/*11.
Implemente um programa em C# que ajude sua equipe a localizar o maior tesouro. 
Para isso, você deve:
a) Criar uma matriz quadrada (mesmo número de linhas e colunas) de tamanho N x N.
b) Preencher a matriz com números aleatórios entre 1 e 100, 
representando a quantidade de moedas de ouro em cada coordenada da ilha.
c) Exibir a matriz gerada.
d) Calcular a soma das moedas em duas diagonais principais:
- o A diagonal principal que vai do canto superior esquerdo ao canto inferior direito.
- o A diagonal secundária que vai do canto superior direito ao canto inferior esquerdo.
e) Exibir as somas das duas diagonais e indicar qual delas tem mais moedas de ouro para que sua equipe possa
percorrer.*/

using System;
using System.Data;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a ordem da matriz: ");
            int ordem = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[ordem, ordem];

            Console.WriteLine("Mapa do Tesouro (Moedas x Região)");
            FuncoesMatriz.gerarMatriz(matriz);
            FuncoesMatriz.mostrarMatriz(matriz);

            int somaDiagonalPrincipal = FuncoesMatriz.obterSomaDiagonalPrincipal(matriz);
            int somaDiagonalSecundaria = FuncoesMatriz.obterSomaDiagonalSecundaria(matriz);

            Console.WriteLine("Soma da Diagonal Principal:" + somaDiagonalPrincipal);
            Console.WriteLine("Soma da Diagonal Secundária:" + somaDiagonalSecundaria);

            if(somaDiagonalPrincipal > somaDiagonalSecundaria)
                Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
            else
                Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
            
        }
    }
}