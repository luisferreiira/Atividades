using System;
using Atividades.Biblioteca;
// Escreva um programa que sorteie, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
// usuário digita um número e seu programa em C# deve acusar se o número digitado está no vetor ou não. Se
// estiver, diga a posição que está. A verificação deve ser realizada a partir de uma função.
class Exercicio5
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        int[] vetorGerado = new int[tamanhoVetor];
        
        Vetor.geraArray(vetorGerado, tamanhoVetor);

        Console.WriteLine("Insira que Número deseja buscar no Vetor: ");
        int numeroParaBuscar = int.Parse(Console.ReadLine()!);

        Vetor.estaNoVetor(vetorGerado, numeroParaBuscar);

        Vetor.printArray(vetorGerado);

    }
}