using System;
using Atividades.Biblioteca;

// Escreva um programa que leia ou gere um vetor de N elementos inteiros. A seguir, crie uma função que receba
// esse vetor e conte quantos valores impares existem no vetor. Retorne a quantidade de impares.
class Exercicio2
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] vetorGerado = new int[tamanhoVetor];
        
        FuncoesArray.geraArray(vetorGerado, tamanhoVetor);

        FuncoesArray.printArray(vetorGerado);

        int quantidadeImpares = FuncoesArray.contarImparesArray(vetorGerado);

        Console.WriteLine($"Quantidade de Ímpares no Vetor: {quantidadeImpares}"); 
    }
}