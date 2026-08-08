using System;
using System.Security;
namespace Atividades.Biblioteca;

class FuncoesArray
{

    //MÉTODOS PARA VETORES INT
    public static void printArray(int[] vet)
    {
        Console.WriteLine("Mostrando Vetor");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " | ");
        }
        Console.WriteLine();
    }

    public static void geraArray(int[] vet, int n)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vet[i] = rand.Next(1, 100);
        }
        Console.WriteLine("Gerado Vetor Aleatório");
    }

    public static int somarElementosArray(int[] vet)
    {
        int soma = 0;
        for (int i = 0; i < vet.Length; i++)
        {
            soma += vet[i];
        }

        return soma;
    }

    public static int contarImparesArray(int[] vet)
    {
        int quantidadeImpares = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] % 2 != 0)
            {
                quantidadeImpares++;
            }
        }

        return quantidadeImpares;
    }

    public static void estaNoVetor(int[] vet, int n)
    {
        // vetor que vai guardar as posições coincidentes
        int[] posicoes = new int[vet.Length];
        //conta quantas vezes coincidiu
        int contador = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] == n)
            {
                posicoes[contador] = i;
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.Write($"O valor {n} está no vetor, na(s) posição(ões): ");
            for (int j = 0; j < contador; j++)
            {
                Console.Write(posicoes[j] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("O valor não está dentro do vetor");
        }
    }

    public static int[] multiplicaVetores(int[] vet, int[] vet2, int n)
    {
        Console.WriteLine("Multiplicando Vetores");
        int[] vetorResultante = new int[n];

        for (int i = 0; i < vetorResultante.Length; i++)
        {
            vetorResultante[i] = vet[i] * vet2[i];
        }

        return vetorResultante;
    }

    public static void contarOcorrencias(int[] vet, int n)
    {
        int contador = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] == n)
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"O valor {n} aparece {contador} vez(es) no vetor.");
        }
        else
        {
            Console.WriteLine($"O valor {n} não está no vetor.");
        }
    }


    // (SOBR)ESCRITA DE MÉTODOS PARA VETORES DOUBLE

    public static void printArray(double[] vet)
    {
        Console.WriteLine("Mostrando Vetor");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]:F2} | ");
        }
        Console.WriteLine();
    }

    public static void geraArray(double[] vet, int n)
    {
        Random rand = new Random();
        double max = 100.0;
        double min = -100.0;

        for (int i = 0; i < n; i++)
        {
            vet[i] = min + rand.NextDouble() * (max - min);
        }
        Console.WriteLine("Gerado Vetor Aleatório");
    }

    public static double somarElementosArray(double[] vet)
    {
        double soma = 0;
        for (int i = 0; i < vet.Length; i++)
        {
            soma += vet[i];
        }

        return soma;
    }

    public static double buscarMaiorValor(double[] vet)
    {
        double maiorValor = vet[0];

        for (int i = 1; i < vet.Length; i++)
        {
            if (vet[i] > maiorValor)
            {
                maiorValor = vet[i];
            }
        }

        return maiorValor;
    }
    public static double buscarMenorValor(double[] vet)
    {
        double menorValor = vet[0];

        for (int i = 1; i < vet.Length; i++)
        {
            if (vet[i] < menorValor)
            {
                menorValor = vet[i];
            }
        }

        return menorValor;
    }

    // (SOBR)ESCRITA DE MÉTODOS PARA VETORES STRING / CHAR

    public static void printArray(char[] vet)
    {
        Console.WriteLine("Mostrando Vetor");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " | ");
        }
        Console.WriteLine();
    }

    public static char[] lerArray(int n)
    {
        char[] vetorGerado = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Insira o caracter para a posição[{i}]");
            vetorGerado[i] = Convert.ToChar(Console.ReadLine()!);
        }
        return vetorGerado;
    }

    public static char[] inverterArray(char[] vet)
    {
        char[] invertido = new char[vet.Length];
        for (int i = 0; i < vet.Length; i++)
        {
            invertido[i] = vet[vet.Length - 1 - i];
        }
        return invertido;
    }

    public static char[] geraDnaComplementar(char[] vet)
    {
        char[] vetComplementar = new char[vet.Length];

        for (int i = 0; i < vet.Length; i++)
        {
            switch (vet[i])
            {
                case 'A':
                    vetComplementar[i] = 'T';
                    break;
                case 'T':
                    vetComplementar[i] = 'A';
                    break;
                case 'C':
                    vetComplementar[i] = 'G';
                    break;
                case 'G':
                    vetComplementar[i] = 'C';
                    break;
                default:
                    vetComplementar[i] = ' ';
                    break;
            }
        }

        return vetComplementar;
    }

}