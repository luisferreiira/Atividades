using System;
using Atividades.Biblioteca;

class PreProvaExercicio1
{
    static String[] bairros = {"Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé", "Santo Amaro", "Vila Mariana", "Lapa", "Capão Redondo", "Santana"};

    static double calcularMedia(int[] roubos)
    {
        double media = 0, soma = 0, tamanho = roubos.Length;

        for (int i = 0; i < roubos.Length; i++)
            soma+=roubos[i];

        media = soma / tamanho;
        return media;
    }

    static void exibirTop3BairrosViolentos(String[] bairros, int[] roubos)
    {
        int indiceTop1 = 0;
		int indiceTop2 = 0;
		int indiceTop3 = 0;
		int maiorRoubos = roubos[0];
		
		for (int i = 0; i < roubos.Length; i++){
			if (roubos[i] > maiorRoubos){
				maiorRoubos = roubos[i];
				indiceTop1 = i;
			}	
		}
		
		maiorRoubos = roubos[0];
		
		for (int i = 0; i < roubos.Length; i++){
			if (i != indiceTop1){
				if (roubos[i] > maiorRoubos) {
					maiorRoubos = roubos[i];
					indiceTop2 = i;
				}
			}	
		}
		
		maiorRoubos = roubos[0];
		
		for (int i = 0; i < roubos.Length; i++){
			if (i != indiceTop1 && i != indiceTop2){
				if (roubos[i] > maiorRoubos ) {
					maiorRoubos = roubos[i];
					indiceTop3 = i;
				}
			}	
		}
	
		Console.WriteLine("--- TOP 3 BAIRROS MAIS VIOLENTOS ---");
		Console.WriteLine($"1º Lugar: {bairros[indiceTop1]} (Índice {indiceTop1}) - {roubos[indiceTop1]} roubos");
		Console.WriteLine($"2º Lugar: {bairros[indiceTop2]} (Índice {indiceTop2}) - {roubos[indiceTop2]} roubos");
		Console.WriteLine($"3º Lugar: {bairros[indiceTop3]} (Índice {indiceTop3}) - {roubos[indiceTop3]} roubos");
    }



    static void Main()
    {
        int[] roubos = new int[bairros.Length];
        Vetor.lerArray(roubos);
        // int[] roubos = {350, 120, 210, 480, 190, 310, 150, 280, 520, 240};

        Vetor.printArray(roubos);

        Console.WriteLine("\nANÁLISE DE SEGURANÇA PÚBLICA - BAIRROS DE SP");

        double media = calcularMedia(roubos);
        Console.WriteLine($"\nMédia de roubos por bairro: {media:F2} ocorrências");

        exibirTop3BairrosViolentos(bairros, roubos);
    }
}