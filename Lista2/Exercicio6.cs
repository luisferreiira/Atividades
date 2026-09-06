/*6. Faça um programa que leia ou gere duas matrizes N X M de mesma ordem com valores reais. Ofereça ao
usuário um menu de opções: (a) somar as duas matrizes (b) subtrair a primeira matriz da segunda (c)
adicionar uma constante as duas matrizes (d) imprimir as matrizes.
Nas duas primeiras opções uma terceira matriz deve ser criada. Na terceira opção o valor da constante deve
ser lido e o resultado da adição da constante deve ser armazenado na própria matriz.*/

using System;
using Atividades.Biblioteca;
namespace Lista2
{

    class Exercicio6
    {
        static void Main()
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

            String operacao = " ";

            while (!operacao.Equals("s"))
            {
                Console.WriteLine("MENU DE OPERAÇÕES");
                Console.WriteLine("Insira A - Somar Matrizes");
                Console.WriteLine("Insira B - Subtrair Matriz A da Matriz B");
                Console.WriteLine("Insira C - Adicionar Constante as Matrizes");
                Console.WriteLine("Insira D - Mostrar Matrizes");
                Console.WriteLine("Insira S - Sair");
                operacao = Console.ReadLine()!.ToLower();

                int[,] resultante;

                switch (operacao)
                {
                    case "a":
                        resultante = FuncoesMatriz.somarDuasMatrizes(matrizA, matrizB)!;
                        if (resultante != null)
                        {
                            Console.WriteLine("Matriz A+B:");
                            FuncoesMatriz.mostrarMatriz(resultante);
                        }
                        break;
                    case "b":
                        resultante = FuncoesMatriz.subtrairMatrizAdeMatrizB(matrizA, matrizB)!;
                        if (resultante != null)
                        {
                            Console.WriteLine("Matriz A-B:");
                            FuncoesMatriz.mostrarMatriz(resultante);
                        }
                        break;
                    case "c":
                        Console.WriteLine("Insira uma constante para somar às matrizes: ");
                        int constante = int.Parse(Console.ReadLine()!);

                        matrizA = FuncoesMatriz.somarNumeroConstanteNaMatriz(matrizA, constante);
                        Console.WriteLine("Matriz A:");
                        FuncoesMatriz.mostrarMatriz(matrizA);

                        matrizB = FuncoesMatriz.somarNumeroConstanteNaMatriz(matrizB, constante);
                        Console.WriteLine("Matriz B:");
                        FuncoesMatriz.mostrarMatriz(matrizB);
                        break;
                    case "d":
                        Console.WriteLine("Matriz A:");
                        FuncoesMatriz.mostrarMatriz(matrizA);
                        Console.WriteLine("Matriz B:");
                        FuncoesMatriz.mostrarMatriz(matrizB);
                        break;
                    case "s":
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Entrada Inválida");
                        break;
                }
            }
        }
    }
}