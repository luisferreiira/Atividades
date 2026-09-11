using System;

namespace Atividades.Biblioteca;

public class Matriz
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

        int maiorValor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maiorValor)
                    maiorValor = matriz[i, j];
            }
        }

        return maiorValor;
    }

    public static int obterMenorValor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int menorValor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menorValor)
                    menorValor = matriz[i, j];
            }
        }

        return menorValor;
    }

    public static int[] obterDiagonalPrincipal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int[] diagonal_principal = new int[linhas];
        int contador = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (i == j)
                {
                    diagonal_principal[contador] = matriz[i, j];
                    contador++;
                }
            }
        }

        return diagonal_principal;
    }

    public static int[] obterDiagonalSecundaria(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int[] diagonal_secundaria = new int[linhas];
        int contador = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (i + j == linhas - 1)
                {
                    diagonal_secundaria[contador] = matriz[i, j];
                    contador++;
                }
            }
        }

        return diagonal_secundaria;
    }

    public static int contarOcorrenciasNumero(int[,] matriz, int numeroBuscado)
    {
        int ocorrenciasNumero = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == numeroBuscado)
                {
                    ocorrenciasNumero++;
                }
            }
        }
        return ocorrenciasNumero;
    }

    public static int[,]? somarDuasMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] resultante;
        int linhasA = matrizA.GetLength(0);
        int colunasA = matrizA.GetLength(1);

        int linhasB = matrizB.GetLength(0);
        int colunasB = matrizB.GetLength(1);

        if (linhasA == linhasB && colunasB == colunasA)
        {
            resultante = new int[linhasA, colunasA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasB; j++)
                {
                    resultante[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            return resultante;
        }
        else
        {
            Console.WriteLine("A soma não existe, pois as matrizes tem ordens divergentes!");
            return null;
        }
    }

    public static int[,]? subtrairMatrizAdeMatrizB(int[,] matrizA, int[,] matrizB)
    {
        int[,] resultante;
        int linhasA = matrizA.GetLength(0);
        int colunasA = matrizA.GetLength(1);

        int linhasB = matrizB.GetLength(0);
        int colunasB = matrizB.GetLength(1);

        if (linhasA == linhasB && colunasB == colunasA)
        {
            resultante = new int[linhasA, colunasA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasB; j++)
                {
                    resultante[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            return resultante;
        }
        else
        {
            Console.WriteLine("A subtração não existe, pois as matrizes tem ordens divergentes!");
            return null;
        }
    }

    public static int[,] somarNumeroConstanteNaMatriz(int[,] matriz, int constante)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] += constante;
            }
        }

        return matriz;

    }

    public static int[,] somarLinhas(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int[,] resultante = new int[linhas, 1];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultante[i, 0] += matriz[i, j];
            }
        }

        return resultante;
    }

    public static int obterSomaDiagonalPrincipal(int[,] matriz)
    {
        int somaDiagonalPrincipal = 0;
        int[] diagonalPrincipal = Matriz.obterDiagonalPrincipal(matriz);
        for (int i = 0; i < diagonalPrincipal.Length; i++)
            somaDiagonalPrincipal += diagonalPrincipal[i];
        return somaDiagonalPrincipal;
    }
    public static int obterSomaDiagonalSecundaria(int[,] matriz)
    {
        int somaDiagonalSecundaria = 0;
        int[] diagonalSecundaria = Matriz.obterDiagonalSecundaria(matriz);
        for (int i = 0; i < diagonalSecundaria.Length; i++)
            somaDiagonalSecundaria += diagonalSecundaria[i];
        return somaDiagonalSecundaria;
    }

    public static int[,] carregarMatriz(string caminhoArquivo)
    {
        string[] linhas = File.ReadAllLines(caminhoArquivo);
        int numLinhas = linhas.Length;
        int numColunas = linhas[0].Split(',').Length;

        int[,] matriz = new int[numLinhas, numColunas];

        for (int i = 0; i < numLinhas; i++)
        {
            string[] valores = linhas[i].Split(',');
            for (int j = 0; j < numColunas; j++)
            {
                matriz[i, j] = int.Parse(valores[j]);
            }
        }
        return matriz;
    }

    public static int verificarOcorrencias(int[,] matriz, int valorBuscado)
    {
        int linhas = matriz.GetLength(0);  // Obtém o número de linhas
        int colunas = matriz.GetLength(1); // Obtém o número de colunas
        int ocorrencias = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == valorBuscado)
                {
                    Console.WriteLine($" -> Ocorrência encontrada no Setor [{i+1}, {j+1}]");
                    ocorrencias++;
                }
            }
        }

        return ocorrencias;
    }
}