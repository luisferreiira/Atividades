using System;
using Atividades.Biblioteca;
// Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
// vetor.
class Exercicio3
{
    static void Main()
    {
        Console.WriteLine("Insira quantidade de elementos do vetor: ");
        int tamanhoVetor = int.Parse(Console.ReadLine()!);

        double[] vetorGerado = new double[tamanhoVetor];
        
        FuncoesArray.geraArray(vetorGerado, tamanhoVetor);

        FuncoesArray.printArray(vetorGerado);

        double maiorValor = FuncoesArray.buscarMaiorValor(vetorGerado);

        Console.WriteLine($"Maior Valor Encontrado: {maiorValor:F2}"); 
    }
}