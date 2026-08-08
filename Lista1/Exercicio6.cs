using System;
using Atividades.Biblioteca;
// Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
// mesmo índice, colocando o resultado em um terceiro vetor. A multiplicação deve ser feito por meio de uma
// função. Retorne o vetor resultante e apresente.
class Exercicio6
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetores: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] vetorGerado = new int[tamanhoVetor];
        int[] vetorGerado2 = new int[tamanhoVetor];
        int[] vetorResultante = new int[tamanhoVetor];
        
        FuncoesArray.geraArray(vetorGerado, tamanhoVetor);
        FuncoesArray.printArray(vetorGerado);

        Console.WriteLine();

        FuncoesArray.geraArray(vetorGerado2, tamanhoVetor);
        FuncoesArray.printArray(vetorGerado);

        Console.WriteLine();

        vetorResultante = FuncoesArray.multiplicaVetores(vetorGerado, vetorGerado2, tamanhoVetor);

        Console.WriteLine();

        FuncoesArray.printArray(vetorResultante);
    }
}