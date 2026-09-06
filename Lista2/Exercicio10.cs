/*10.
Entrada: A primeira linha da entrada possui um inteiro N 
indicando o número de redes que foram lançadas.
As próximas N linhas descrevem as regiões cobertas pelas redes:
cada uma contém quatro inteiros Xi e Xf , Yi e Yf.
A região coberta pela rede em questão contém todo ponto (X, Y) 
tal que Xi ≤ X ≤ Xf e Yi ≤ Y ≤ Yf
Saída: A saída deve conter apenas uma linha contendo a área da região do mar
realmente aproveitada pelos pescadores,ou seja,
a área total da região do mar coberta por pelo menos uma rede de pesca.*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio10
    {
        static void Main(string[] args)
        {

            int[,] mar = new int[501, 501];

            Console.WriteLine("Insira a quantidade de redes: ");
            int quantidadeRedes = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < quantidadeRedes; i++)
            {
                Console.WriteLine("Insira Xi, Xf, Yi, Yf");
                string dimensoes = Console.ReadLine()!;
                string[] partes = dimensoes.Split(' ');

                int xi = int.Parse(partes[0]);
                int xf = int.Parse(partes[1]);
                int yi = int.Parse(partes[2]);
                int yf = int.Parse(partes[3]);

                for(int x = xi; x <= xf; x++)
                {
                    for(int y = yi; y <= yf; y++)
                    {
                        mar[x,y] = 1;
                    }
                }
            }

            int area = 0;
            for(int x = 0; x < 501; x++)
            {
                for(int y = 0; y < 501; y++)
                {
                    if(mar[x,y] == 1)
                    {
                        area++;
                    }
                }
            }

            Console.WriteLine("Área: " + area);
        }
    }
}