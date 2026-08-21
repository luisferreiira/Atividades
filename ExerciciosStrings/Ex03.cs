using System;

class Ex03
{
    static void Main()
    {
        // string texto = "HELLO";
        // Console.WriteLine(texto[0]);
        // Console.WriteLine(texto[4]);
        // Console.WriteLine((int)texto[0]);

        // string mensagem = "Olá, Mundo!";
        // Console.WriteLine(mensagem);
        // Console.WriteLine("Tamanho: " + mensagem.Length);

        // String nome;
        // Console.WriteLine("Digite seu nome: ");
        // nome = Console.ReadLine()!;
        // char[] nomeArray = nome.ToCharArray();
        // nomeArray[0] = (char)(nomeArray[0] - 32);
        // Console.WriteLine("Nome: " + new string(nomeArray));

        // char[] sigla = { 'I', 'F', 'S', 'U', 'L' };
        // string nome = new string(sigla);

        // Console.WriteLine(sigla);
        // Console.WriteLine(nome);

        // string cidade = "Machado";
        // string maiuscula = cidade.ToUpper();

        // Console.WriteLine(cidade);
        // Console.WriteLine(maiuscula);

        // char[] letras = { 'c', 'A', 'b', 'B', 'a' };
        // Array.Sort(letras);

        // Console.WriteLine(new string(letras));

        // string nome1 = "Ana";
        // string nome2 = "Ana";
        // int resultado = string.Compare(nome1, nome2);

        // Console.WriteLine(resultado);

        // if (resultado == 0)
        //     Console.WriteLine("Textos iguais");
        // else if (resultado < 0)
        //     Console.WriteLine("O primeiro vem antes");
        // else
        //     Console.WriteLine("O primeiro vem depois");

        // string texto = "Exemplo de string";

        // string parte1 = texto.Substring(8);
        // string parte2 = texto.Substring(0, 7);

        // Console.WriteLine(parte1);
        // Console.WriteLine(parte2);

        Console.Write("Digite o primeiro texto: ");
        string texto1 = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo texto: ");
        string texto2 = Console.ReadLine() ?? "";

        // mostrar o tamanho de cada texto
        Console.WriteLine("Tamanho do Texto 1: " + texto1.Length); 
        Console.WriteLine("Tamanho do Texto 2: " + texto2.Length);

        //  apresentar ambos em letras maiúsculas
        Console.WriteLine("Texto 1 em UpperCase: " + texto1.ToUpper());
        Console.WriteLine("Texto 2 em UpperCase: " + texto2.ToUpper());

        // compará-los ignorando diferenças entre maiúsculas e minúsculas e exibir uma mensagem informando se são equivalentes.
        string textoNormalizado1 = texto1.ToLower();
        string textoNormalizado2 = texto2.ToLower();

        int resultado = string.Compare(textoNormalizado1, textoNormalizado2);

        Console.WriteLine("Comparação: " + resultado);

        if (resultado == 0)
            Console.WriteLine("Textos iguais");
        else
            Console.WriteLine("Textos Diferentes");


    }
}