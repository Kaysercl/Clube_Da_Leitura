using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class TelaExcluir
        {

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

                TelaFerramentas.Mensagem("Amigo excluído do cadastro!", ConsoleColor.Green);
            }

            public static void ExcluirRevista(ref Revista[] revistasCadastradas, ref Revista[] novoRevistasCadastradas)
            {
                bool existeRevista = false;
                string idRevistaExcluida = null;

                //verificação pelo nome se o id digitado existe
                while (existeRevista == false)
                {
                    Console.Write("Digite o id da revista que será excluída do cadastro: ");
                    idRevistaExcluida = Console.ReadLine();

                    for (int i = 0; i < revistasCadastradas.Length; i++)
                    {
                        if (revistasCadastradas[i] != null && idRevistaExcluida == revistasCadastradas[i].id)
                        {
                            existeRevista = true;
                            break;
                        }
                    }
                }

                int j = 0;

                for (int i = 0; i < revistasCadastradas.Length; i++)
                {
                    if (revistasCadastradas[i] != null && revistasCadastradas[i].id != idRevistaExcluida)
                    {
                        novoRevistasCadastradas[j] = revistasCadastradas[i];

                        j++;
                        //break;
                    }
                }

                revistasCadastradas = novoRevistasCadastradas;

                TelaFerramentas.Mensagem("Revista excluída do cadastro!", ConsoleColor.Green);
            }

            public static void ExcluirMulta(Amigo[] amigosCadastrados)
            {
                Console.Write("Digite o nome do amigo que irá quitar a multa: ");
                string nomeQuitarMulta = Console.ReadLine();

                for (int i = 0; i < amigosCadastrados.Length; i++)
                {
                    if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == true)
                    {
                        TelaFerramentas.Mensagem("Multa quitada!", ConsoleColor.Green);
                        amigosCadastrados[i].temMulta = false;
                        break;

                    }
                    else if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == false)
                    {
                        TelaFerramentas.Mensagem("O amigo não tem multa em aberto!", ConsoleColor.Red);
                        break;
                    }
                }
            }

            public static void ExcluirEmprestimo(ref Amigo[] amigosCadastrados, ref Emprestimo[] emprestimosRealizados, ref Emprestimo[] novoEmprestimosRealizados)
            {
                Console.Write("Digite o nome do amigo que está devolvendo a revista: ");
                string nomeAmigoDevolucao = Console.ReadLine();

                for (int i = 0; i < emprestimosRealizados.Length; i++)
                {
                    if (emprestimosRealizados[i] != null && emprestimosRealizados[i].amigo.nome == nomeAmigoDevolucao)
                    {

                        if (emprestimosRealizados[i].dataDevolucao < DateTime.Now)
                        {
                            TelaFerramentas.Mensagem("O amigo deve pagar uma multa pelo atraso!", ConsoleColor.Red);

                            for (int k = 0; k < amigosCadastrados.Length; k++)
                            {
                                if (amigosCadastrados[k].nome == nomeAmigoDevolucao)
                                {
                                    amigosCadastrados[k].temMulta = true;
                                    break;
                                }
                            }

                        }

                        break;
                    }
                }

                int j = 0;

                for (int i = 0; i < emprestimosRealizados.Length; i++)
                {
                    if (emprestimosRealizados[i] != null && emprestimosRealizados[i].amigo.nome != nomeAmigoDevolucao)
                    {
                        novoEmprestimosRealizados[j] = emprestimosRealizados[i];

                        j++;
                        //break;
                    }
                }

                emprestimosRealizados = novoEmprestimosRealizados;

                TelaFerramentas.Mensagem("Empréstimo finalizado!", ConsoleColor.Green);
            }

        }
    }
}