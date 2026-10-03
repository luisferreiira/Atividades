using System;

using Atividades.Biblioteca;

class PreProvaExercicio2
{
	
	static Double calcularPercentualDesmatamento(int[,] matriz){
		
		int linhas = matriz.GetLength(0);
		int colunas = matriz.GetLength(1);
		double areaDesmatada = 0;
		
		for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i,j] == 0)
							areaDesmatada++;
                }
            }
		
		double percentualAreaDesmatada = (areaDesmatada * 100) / 36;
		
		return percentualAreaDesmatada;
	}
	
	static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual){
		double percentualAreaDesmatadaAnterior = calcularPercentualDesmatamento(matrizAnterior);
		double percentualAreaDesmatadaAtual = calcularPercentualDesmatamento(matrizAtual);
		
		if (percentualAreaDesmatadaAnterior > percentualAreaDesmatadaAtual){
			Console.WriteLine($"Houve redução nas Áreas Desmatadas – Anterior {percentualAreaDesmatadaAnterior:F2}% -> Atual {percentualAreaDesmatadaAtual:F2}%");
		}
		else if (percentualAreaDesmatadaAnterior < percentualAreaDesmatadaAtual) {
			Console.WriteLine($"Houve aumento nas Áreas Desmatadas – Anterior {percentualAreaDesmatadaAnterior:F2}% -> Atual {percentualAreaDesmatadaAtual:F2}%");
		}
		else {
			Console.WriteLine($"Não houve diferença considerável nas Áreas Desmatadas – Anterior {percentualAreaDesmatadaAnterior:F2}% -> Atual {percentualAreaDesmatadaAtual:F2}%");
		}
					
	}
	
	static void Main()
	{
		int[,] regiao6MesesAtras = Matriz.carregarMatriz("ProvaTipo1/dados_matriz_6meses_atras.csv");
		int[,] regiaoAtual = Matriz.carregarMatriz("ProvaTipo1/dados_matriz_atual.csv");
		double percentualAreaDesmatada = 0;
		
		Console.WriteLine("Matriz 6 Meses Atrás:");
		Matriz.mostrarMatriz(regiao6MesesAtras);
		
		Console.WriteLine("Matriz Atual:");
		Matriz.mostrarMatriz(regiaoAtual);
		
		Console.WriteLine("Percentual de ocorrências na matriz 6 meses atrás");
		percentualAreaDesmatada = calcularPercentualDesmatamento(regiao6MesesAtras);
		Console.WriteLine($"Área Desmatada (Código 0): {percentualAreaDesmatada:F2}%");
		
		Console.WriteLine("Percentual de ocorrências na matriz atual");
		percentualAreaDesmatada = calcularPercentualDesmatamento(regiaoAtual);
		Console.WriteLine($"Área Desmatada (Código 0): {percentualAreaDesmatada:F2}%");
		
		
		analisarAumento(regiao6MesesAtras, regiaoAtual);
		
	}
}