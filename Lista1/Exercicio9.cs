using System;
using Atividades.Biblioteca;
// Leia um vetor DNA de caracteres para receber as letras A, T, C e G que representam as bases do DNA. Este
// vetor será responsável por representar uma fita de um gene de até 50 bases. Gere o vetor complementar ao
// vetor DNA e o apresente (Lembrando as bases complementares A=T C=G).
class Exercicio9
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        char[] fitaOriginal = FuncoesArray.lerArray(tamanhoVetor);

        Console.WriteLine("DNA Complementar");

        char[] fitaComplementar = FuncoesArray.geraDnaComplementar(fitaOriginal);

        FuncoesArray.printArray(fitaComplementar);
    }
}