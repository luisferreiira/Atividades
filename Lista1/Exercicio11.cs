using System;
using Atividades.Biblioteca;
// Entrada A entrada consiste de uma única linha, contendo uma mensagem escrita na língua do P
// eletrônica de Jacy e Kátia.
// Saída Seu programa deve produzir uma única linha, contendo a mensagem decodificada.
// Restrições A mensagem contém apenas letras maiúsculas e minúsculas e espaços em branco. A
// mensagem tem entre 1 e 1000 caracteres. Não há dois espaços em branco consecutivos na mensagem.
class Exercicio11
{
    static void Main()
    {
        Console.WriteLine("Insira a mensagem criptografada: ");
        string mensagem = Console.ReadLine()!;

        string mensagemDecodificada = FuncoesArray.decodificarLinguaP(mensagem);

        Console.WriteLine($"Mensagem Decodificada: {mensagemDecodificada}");
    }
}