using System;
using Atividades.Biblioteca;
using System.IO; 

    class Matriz02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carregando CSV externo para Matriz: ");
            int[,] matriz = Matriz.carregarMatriz("ArquivosImportados/ocorrencias.csv");

            Matriz.mostrarMatriz(matriz);

            Console.WriteLine("Insira o valor que deseja buscar: ");
            int valorBuscado = int.Parse(Console.ReadLine()!);

            int ocorrencias = Matriz.verificarOcorrencias(matriz, valorBuscado);
            Console.WriteLine($"Ocorrências de {valorBuscado}: {ocorrencias}");

        }
    }
