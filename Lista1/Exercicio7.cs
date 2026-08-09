using System;
using Atividades.Biblioteca;
// Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
// se encontra no vetor. Apresente também todos elementos do vetor. A verificação deve ser realizada a partir
// de uma função.
class Exercicio7
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] vetorGerado = new int[tamanhoVetor];

        FuncoesArray.geraArray(vetorGerado, tamanhoVetor);

        Console.WriteLine("Insira que Número deseja buscar no Vetor: ");
        int numeroParaBuscar = int.Parse(Console.ReadLine()!);

        FuncoesArray.contarOcorrencias(vetorGerado, numeroParaBuscar);

        FuncoesArray.printArray(vetorGerado);
    }
}