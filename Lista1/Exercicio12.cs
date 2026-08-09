using System;
using Atividades.Biblioteca;
// Entrada
// A entrada contém uma única linha, contendo cinco números Ni (1 ≤ i ≤ 5), todos com uma casa decimal, indicando as
// notas recebidas pela agremiação em um dos quesitos. Armazene em um vetor e passa como parâmetro para a
// função.
// Saída
// Sua função deve retornar um único número com exatamente uma casa decimal, a nota final da escola de samba no
// quesito considerado.
class Exercicio12
{
    static void Main()
    {
        Console.WriteLine("Insira as notas: ");
        string notas = Console.ReadLine()!;
        
        double notaFinal = FuncoesArray.calcularNota(notas);

        Console.WriteLine($"Nota Final: {notaFinal:F1}");


    }
}