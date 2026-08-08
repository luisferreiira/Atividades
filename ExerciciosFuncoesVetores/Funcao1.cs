using System;

class Funcao1
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
        int[] vetorBase = {5,10,15,20,25};

        Console.WriteLine("Insira um valor: ");
        int valorParaPesquisar = int.Parse(Console.ReadLine()!);

        int indice = buscarIndice(vetorBase, valorParaPesquisar);

        Console.WriteLine(indice == -1 ? "O valor não está no vetor" : $"Valor foi encontrado na posição {indice}");
    }
}