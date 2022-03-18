using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class TelaEditar
        {
            public static void EditarAmigo(ref Amigo[] amigosCadastrados)
            {

                bool existeAmigo = false;
                string nomeAmigoEditado = null;
                int posArrayEditada = 0;

                //verificação pelo nome se o amigo digitado existe
                while (existeAmigo == false)
                {
                    Console.Write("Digite o nome do amigo que será editado no cadastro: ");
                    nomeAmigoEditado = Console.ReadLine();

                    for (int i = 0; i < amigosCadastrados.Length; i++)
                    {
                        if (amigosCadastrados[i] != null && nomeAmigoEditado == amigosCadastrados[i].nome)
                        {
                            posArrayEditada = i;
                            existeAmigo = true;
                            break;
                        }
                    }
                }

                Console.Write("Digite o novo nome do responsável: ");
                amigosCadastrados[posArrayEditada].nomeResponsavel = Console.ReadLine();

                Console.Write("Digite o novo telefone do amigo: ");
                amigosCadastrados[posArrayEditada].telefone = Console.ReadLine();

                Console.Write("Digite o novo endereço do amigo: ");
                amigosCadastrados[posArrayEditada].endereço = Console.ReadLine();

                TelaFerramentas.Mensagem("Cadastro do amigo editado!", ConsoleColor.Green);

            }

            public static void EditarRevista(ref Revista[] revistasCadastradas, ref Caixa[] caixasCadastradas)
            {

                bool existeRevista = false;
                string idRevistaEditada = null;
                int posArrayEditada = 0;

                //verificação pelo nome se o id digitado existe
                while (existeRevista == false)
                {
                    Console.Write("Digite o id da revista que será editada no cadastro: ");
                    idRevistaEditada = Console.ReadLine();

                    for (int i = 0; i < revistasCadastradas.Length; i++)
                    {
                        if (revistasCadastradas[i] != null && idRevistaEditada == revistasCadastradas[i].id)
                        {
                            posArrayEditada = i;
                            existeRevista = true;
                            break;
                        }
                    }
                }

                Console.Write("Digite o novo tipo da coleção da revista: ");
                revistasCadastradas[posArrayEditada].tipoColecao = Console.ReadLine();

                Console.Write("Digite o novo número da edição da revista: ");
                revistasCadastradas[posArrayEditada].numeroEdicao = int.Parse(Console.ReadLine());

                Console.Write("Digite o novo ano da revista: ");
                revistasCadastradas[posArrayEditada].ano = int.Parse(Console.ReadLine());

                Console.Write("Digite o número da nova caixa da revista: ");
                int novaCaixaRevista = int.Parse(Console.ReadLine());

                for (int i = 0; i < caixasCadastradas.Length; i++)
                {
                    if (caixasCadastradas[i] != null && caixasCadastradas[i].numero == novaCaixaRevista)
                    {
                        revistasCadastradas[posArrayEditada].caixa = caixasCadastradas[i];
                    }
                }

                TelaFerramentas.Mensagem("Cadastro da revista editado!", ConsoleColor.Green);
            }

        }
    }
}