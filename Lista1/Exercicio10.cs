using System;
using Atividades.Biblioteca;
// Tentando descobrir se um dado era viciado, um dono de cassino honesto o lançou N vezes. Dados os n
// resultados dos lançamentos que devem ser armazenados em um vetor, crie uma função para determinar o
// número de ocorrências de cada face. Retorne o vetor de ocorrencias resultante.
class Exercicio10
{
    static void Main()
    {
        // gerar vetor aleatório (1 - 6) e solicitar quantas vezes girou
        // percorrer com for e contar as ocorrências
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] resultadosDados = new int[tamanhoVetor];
        int[] ocorrencias = new int[6];

        FuncoesArray.geraArrayDados(resultadosDados, tamanhoVetor);

        FuncoesArray.printArray(resultadosDados);

        ocorrencias = FuncoesArray.contarOcorrenciasDados(resultadosDados);

        Console.WriteLine("Faces");
        Console.WriteLine("1 | 2 | 3 | 4 | 5 | 6 |");

        Console.WriteLine("Ocorrências");
        FuncoesArray.printArray(ocorrencias);
    }
}