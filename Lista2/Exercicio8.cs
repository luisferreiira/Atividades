/*8.
Entrada
A entrada contém um único conjunto de testes, que deve ser lido do teclado
A primeira linha da entrada contém um número inteiro N (2 <= N <= 500)
 representando o número de registros de raios no relatório. 
 Cada uma das N linhas seguintes contém 2 números inteiros X, Y ( 0 <= X , Y ≤ 500),
  representando o registro de um raio que caiu no quadrante cujas coordenadas são (X, Y).
Saída
Seu programa deve imprimir 1 se um raio caiu alguma vez em um mesmo lugar ou 0 caso isso não ocorreu,
*/

using System;
using Atividades.Biblioteca;

namespace Lista2
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de registros:");
            int quantidadeRegistros = int.Parse(Console.ReadLine()!);

            Boolean[,] mapa = new Boolean[501, 501]; // todas as posições falsas
            Boolean encontrouRepetido = false;

            if (quantidadeRegistros >= 2)
            {
                Console.WriteLine("Insira linha a linha as coodernadas dos registros:");
                Console.WriteLine("Exemplo: 1 1");

                for (int i = 0; i < quantidadeRegistros; i++)
                {
                    string linha = Console.ReadLine()!;
                    string[] partes = linha.Split(' ');

                    int x = int.Parse(partes[0]);
                    int y = int.Parse(partes[1]);

                    if (mapa[x, y])
                        encontrouRepetido = true;
                    else
                        mapa[x, y] = true;
                }

                if (encontrouRepetido)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("Entrada Inválida");
            }

        }
    }
}