using System;
using Atividades.Biblioteca;
// Leia um vetor de caracteres. Utilize a função Length para obter a quantidade de elementos do vetor de
// caracteres. Escreva o vetor lido em ordem inversa. A inversão deve ser realizada a partir de uma função.
class Exercicio8
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        char[] vetorCaracteres = FuncoesArray.lerArray(tamanhoVetor);
        char[] vetorCaracteresInvertido = FuncoesArray.inverterArray(vetorCaracteres);

        FuncoesArray.printArray(vetorCaracteres);

        Console.WriteLine("Vetor Invertido");

        FuncoesArray.printArray(vetorCaracteresInvertido);

    }
}