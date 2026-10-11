using System;

using Atividades.Biblioteca;

class Exercicio0910
{
    static void gerarMatrizEntre1e0(int[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(0, 2);
            }
        }
    }

    static void verificarCobertura(int[,] matrizAnterior, int[,] matrizAtual)
    {
        int linhas = matrizAnterior.GetLength(0);
        int colunas = matrizAnterior.GetLength(1);
        int coberturaAnterior = 0, coberturaAtual = 0;

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
            {
                if(matrizAnterior[i,j] == 1)
                    coberturaAnterior++;

                if(matrizAtual[i,j] == 1)
                    coberturaAtual++;
            }
        }

        Console.WriteLine($"Total da Área Coberta 6 Meses Atrás: {coberturaAnterior}");
        double porcentagemAnterior = (coberturaAnterior * 100.0) / (linhas * colunas);
        Console.WriteLine($"Total Porcentagem da Área Coberta 6 Meses Atrás: {porcentagemAnterior:F2}%");

        Console.WriteLine();

        Console.WriteLine($"Total da Área Coberta Atualmente: {coberturaAtual}");
        double porcentagemAtual = (coberturaAtual * 100.0) / (linhas * colunas);
        Console.WriteLine($"Total Porcentagem da Área Coberta Atualmente: {porcentagemAtual:F2}%");

        Console.WriteLine();

        if (coberturaAtual > coberturaAnterior)
				Console.WriteLine($"Avaliação: Houve Aumento de {(porcentagemAtual - porcentagemAnterior):F2}%");
			else if (coberturaAtual == coberturaAnterior)
				Console.WriteLine($"Avaliação: NÃO Houve Redução ou Aumento considerável");
			else
				Console.WriteLine($"Avaliação: Houve Redução de {(porcentagemAnterior - porcentagemAtual):F2}%");


    }
    static void Main()
    {
        Console.WriteLine("Insira a quantidade de linhas e colunas da matriz: ");
        Console.WriteLine("Exemplo: 5 5");
        string tamanho = Console.ReadLine()!
        ;
        string[] partes = tamanho.Split(' ');
        int linhas = int.Parse(partes[0]);
        int colunas = int.Parse(partes[1]);

        int[,] matrizAnterior = new int[linhas,colunas];
        int[,] matrizAtual = new int[linhas,colunas];

        gerarMatrizEntre1e0(matrizAnterior);
        gerarMatrizEntre1e0(matrizAtual);

        Console.WriteLine("Mostrando Área 6 Meses Atrás");
        Matriz.mostrarMatriz(matrizAnterior);

        Console.WriteLine();

        Console.WriteLine("Mostrando Área Atual");
        Matriz.mostrarMatriz(matrizAtual);

        verificarCobertura(matrizAnterior, matrizAtual);
        

    }
}