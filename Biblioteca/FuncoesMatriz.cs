using System;

namespace Atividades.Biblioteca;

public class FuncoesMatriz
{
    public static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);  // Obtém o número de linhas
        int colunas = matriz.GetLength(1); // Obtém o número de colunas

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            } // fim for j
        } // fim for i
    }

    public static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    public static void gerarMatriz(int[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(0, 100);
            }
        }
    }

    public static int obterMaiorValor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int maiorValor = matriz[0,0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i,j] > maiorValor)
                    maiorValor = matriz[i, j];
            }
        }

        return maiorValor;
    }

    public static int obterMenorValor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int menorValor = matriz[0,0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i,j] < menorValor)
                    menorValor = matriz[i, j];
            }
        }

        return menorValor;
    }
}