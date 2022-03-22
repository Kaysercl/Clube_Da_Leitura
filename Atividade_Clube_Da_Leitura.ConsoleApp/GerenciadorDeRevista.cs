using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeRevista
        {
            public static void CadastrarRevista(Caixa[] caixasCadastratas, Revista[] revistaCadastrados, Categoria[] categoriasCadastradas, ref int indiceRevista)
            {
                Revista revista = new Revista();

                bool existeId = true;
                string idRevista = null;

                //verificação se o id digitado já não existe
                while (existeId == true)
                {
                    Console.Write("Digite o id da revista: ");
                    idRevista = Console.ReadLine();

                    for (int i = 0; i < revistaCadastrados.Length; i++)
                    {
                        if (revistaCadastrados[i] != null && revistaCadastrados[i].id == idRevista)
                        {
                            existeId = true;
                            break;
                        }
                        else
                        {
                            existeId = false;
                            continue;
                        }
                    }
                }

                Console.Write("Digite o tipo da coleção: ");
                string tipoColecaoRevista = Console.ReadLine();
                Console.Write("Digite o número da edição: ");
                string numeroEdicaoRevista = Console.ReadLine();
                Console.Write("Digite o ano da revista: ");
                string anoRevista = Console.ReadLine();

                revista.id = idRevista;
                revista.tipoColecao = tipoColecaoRevista;
                revista.numeroEdicao = int.Parse(numeroEdicaoRevista);
                revista.ano = int.Parse(anoRevista);
                revista.estaReservada = false;

                bool existeCaixa = false;

                //verificação se a caixa digitada existe
                while (existeCaixa == false)
                {
                    Console.Write("Digite o número da caixa em que está a revista: ");
                    string numeroCaixaRevista = Console.ReadLine();

                    for (int i = 0; i < caixasCadastratas.Length; i++)
                    {
                        if (caixasCadastratas[i] != null && int.Parse(numeroCaixaRevista) == caixasCadastratas[i].numero)
                        {
                            revista.caixa = caixasCadastratas[i];
                            existeCaixa = true;
                            break;
                        }
                    }
                }

                bool existeCategoria = false;

                //verificação se a categoria digitada existe
                while (existeCategoria == false)
                {
                    Console.Write("Digite o nome da categoria da revista: ");
                    string nomeCategoriaRevista = Console.ReadLine();

                    for (int i = 0; i < categoriasCadastradas.Length; i++)
                    {
                        if (categoriasCadastradas[i] != null && nomeCategoriaRevista == categoriasCadastradas[i].nome)
                        {
                            revista.categoria = categoriasCadastradas[i];
                            existeCategoria = true;
                            break;
                        }
                    }
                }

                revistaCadastrados[indiceRevista] = revista;
                indiceRevista++;

                GerenciadorDeFerramentas.Mensagem("Revista cadastrada!", ConsoleColor.Green);
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

                GerenciadorDeFerramentas.Mensagem("Cadastro da revista editado!", ConsoleColor.Green);
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

                GerenciadorDeFerramentas.Mensagem("Revista excluída do cadastro!", ConsoleColor.Green);
            }

            public static void VisualizarRevistas(ref Revista[] revistasCadastradas)
            {
                GerenciadorDeFerramentas.Mensagem("Revistas cadastradas: ", ConsoleColor.Yellow);

                for (int i = 0; i < revistasCadastradas.Length; i++)
                {
                    if (revistasCadastradas[i] != null)
                    {
                        Console.WriteLine("Id da revista: " + revistasCadastradas[i].id);
                        Console.WriteLine("Tipo da coleção: " + revistasCadastradas[i].tipoColecao);
                        Console.WriteLine("Edição: " + revistasCadastradas[i].numeroEdicao);
                        Console.WriteLine("Ano: " + revistasCadastradas[i].ano);
                        Console.WriteLine("Caixa: " + revistasCadastradas[i].caixa.numero);
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}