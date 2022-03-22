using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeMulta
        {
            public static void ExcluirMulta(Amigo[] amigosCadastrados)
            {
                Console.Write("Digite o nome do amigo que irá quitar a multa: ");
                string nomeQuitarMulta = Console.ReadLine();

                for (int i = 0; i < amigosCadastrados.Length; i++)
                {
                    if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == true)
                    {
                        GerenciadorDeFerramentas.Mensagem("Multa quitada!", ConsoleColor.Green);
                        amigosCadastrados[i].temMulta = false;
                        break;

                    }
                    else if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == false)
                    {
                        GerenciadorDeFerramentas.Mensagem("O amigo não tem multa em aberto!", ConsoleColor.Red);
                        break;
                    }
                }
            }
        }
    }
}