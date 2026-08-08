using System;
using Atividades.Biblioteca;

// Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo
// usuário) e passe o mesmo como parâmetro para uma função que retorne a soma de seus elementos.
class Exercicio1
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] vetorGerado = new int[tamanhoVetor];
        
        FuncoesArray.geraArray(vetorGerado, tamanhoVetor);

        FuncoesArray.printArray(vetorGerado);

        int somaVetor = FuncoesArray.somarElementosArray(vetorGerado);

        Console.WriteLine($"Soma dos Valores do Vetor: {somaVetor}"); 

        
    }
}