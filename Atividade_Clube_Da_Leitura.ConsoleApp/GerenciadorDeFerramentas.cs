using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeFerramentas
        {
            public static void Mensagem(string mensagem, ConsoleColor cor)
            {
                Console.ForegroundColor = cor;
                Console.WriteLine();
                Console.WriteLine(mensagem);
                Console.ResetColor();
                Console.WriteLine();
            }

        }
    }
}