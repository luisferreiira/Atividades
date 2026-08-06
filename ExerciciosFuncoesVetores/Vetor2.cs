using System;

class Vetor2
{
    static int buscarIndice(int[] vetor, int valorPesquisado)
    {
        int indiceEncontrado = -1;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorPesquisado)
            {
                indiceEncontrado = i;
                break;
            }
        }
        return indiceEncontrado;
    }

    static void Main()
    {
        // Crie um programa em C# que possua uma função chamada buscarIndice.
        // A função deverá:
        // Receber um vetor de números inteiros;
        // Receber o valor que será pesquisado;
        // Percorrer o vetor procurando pelo valor;
        // Retornar o índice da primeira posição em que o valor for encontrado;
        // Retornar - 1 caso o valor não exista no vetor.

        int[] vetorBase = {5,10,15,20,25};

        Console.WriteLine("Insira um valor: ");
        int valorParaPesquisar = int.Parse(Console.ReadLine());

        int indice = buscarIndice(vetorBase, valorParaPesquisar);

        Console.WriteLine(indice == -1 ? "O valor não está no vetor" : $"Valor foi encontrado na posição {indice}");



    }
}