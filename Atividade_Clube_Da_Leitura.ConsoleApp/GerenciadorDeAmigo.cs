using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeAmigo
        {
            public static void CadastrarAmigo(Amigo[] amigosCadastrados, ref int indiceAmigo)
            {
                Amigo amigo = new Amigo();

                bool existeAmigo = true;
                string nomeAmigo = null;

                //verificação pelo nome se o amigo já não está cadastrado
                while (existeAmigo == true)
                {
                    Console.Write("Digite o nome do amigo: ");
                    nomeAmigo = Console.ReadLine();

                    for (int i = 0; i < amigosCadastrados.Length; i++)
                    {
                        if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeAmigo)
                        {
                            existeAmigo = true;
                            break;
                        }
                        else
                        {
                            existeAmigo = false;
                            continue;
                        }
                    }
                }

                Console.Write("Digite o nome do responsável: ");
                string responsavelAmigo = Console.ReadLine();
                Console.Write("Digite o telefone do amigo: ");
                string telefoneAmigo = Console.ReadLine();
                Console.Write("Digite o endereço do amigo: ");
                string enderecoAmigo = Console.ReadLine();

                amigo.nome = nomeAmigo;
                amigo.nomeResponsavel = responsavelAmigo;
                amigo.endereço = enderecoAmigo;
                amigo.telefone = telefoneAmigo;
                amigo.temMulta = false;

                amigosCadastrados[indiceAmigo] = amigo;
                indiceAmigo++;

                GerenciadorDeFerramentas.Mensagem("Amigo cadastrado!", ConsoleColor.Green);
            }

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

                GerenciadorDeFerramentas.Mensagem("Cadastro do amigo editado!", ConsoleColor.Green);

            }

            public static void ExcluirAmigo(ref Amigo[] amigosCadastrados, ref Amigo[] novoAmigosCadastrados)
            {

                bool existeAmigo = false;
                string nomeAmigoExcluido = null;

                //verificação pelo nome se o amigo digitado existe
                while (existeAmigo == false)
                {
                    Console.Write("Digite o nome do amigo que será excluído do cadastro: ");
                    nomeAmigoExcluido = Console.ReadLine();

                    for (int i = 0; i < amigosCadastrados.Length; i++)
                    {
                        if (amigosCadastrados[i] != null && nomeAmigoExcluido == amigosCadastrados[i].nome)
                        {
                            existeAmigo = true;
                            break;
                        }
                    }
                }

                int j = 0;

                for (int i = 0; i < amigosCadastrados.Length; i++)
                {
                    if (amigosCadastrados[i] != null && amigosCadastrados[i].nome != nomeAmigoExcluido)
                    {
                        novoAmigosCadastrados[j] = amigosCadastrados[i];

                        j++;
                        //break;
                    }
                }

                amigosCadastrados = novoAmigosCadastrados;

                GerenciadorDeFerramentas.Mensagem("Amigo excluído do cadastro!", ConsoleColor.Green);
            }

        }

    }
}