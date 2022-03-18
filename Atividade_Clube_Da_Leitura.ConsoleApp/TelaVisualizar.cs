using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class TelaVisualizar
        {
            public static void VisualizarAmigos(ref Amigo[] amigosCadastrados)
            {
                TelaFerramentas.Mensagem("Amigos cadastrados: ", ConsoleColor.Yellow);

                for (int i = 0; i < amigosCadastrados.Length; i++)
                {
                    if (amigosCadastrados[i] != null)
                    {
                        Console.WriteLine("Nome do amigo: " + amigosCadastrados[i].nome);
                        Console.WriteLine("Nome do responsável: " + amigosCadastrados[i].nomeResponsavel);
                        Console.WriteLine("Telefone do amigo: " + amigosCadastrados[i].telefone);
                        Console.WriteLine("Endereço do amigo: " + amigosCadastrados[i].endereço);

                        Console.WriteLine();

                    }

                }
            }

            public static void VisualizarRevistas(ref Revista[] revistasCadastradas)
            {
                TelaFerramentas.Mensagem("Revistas cadastradas: ", ConsoleColor.Yellow);

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

            public static void VisualizarEmprestimosEmAberto(Emprestimo[] emprestimosRealizados)
            {
                TelaFerramentas.Mensagem("Empréstimos em aberto: ", ConsoleColor.Yellow);

                for (int i = 0; i < emprestimosRealizados.Length; i++)
                {
                    if (emprestimosRealizados[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (emprestimosRealizados[i].dataDevolucao >= DateTime.Today)
                        {
                            Console.WriteLine("Nome do amigo: " + emprestimosRealizados[i].amigo.nome);
                            Console.WriteLine("Nome do responsável: " + emprestimosRealizados[i].amigo.nomeResponsavel);
                            Console.WriteLine("Telefone do amigo: " + emprestimosRealizados[i].amigo.telefone);
                            Console.WriteLine("Endereço do amigo: " + emprestimosRealizados[i].amigo.endereço);
                            Console.WriteLine("Tipo de coleção da revista: " + emprestimosRealizados[i].revista.tipoColecao);
                            Console.WriteLine("Número de edição da revista: " + emprestimosRealizados[i].revista.numeroEdicao);
                            Console.WriteLine("Ano da revista: " + emprestimosRealizados[i].revista.ano);
                            Console.WriteLine("Número da caixa da revista: " + emprestimosRealizados[i].revista.caixa.numero);
                            Console.WriteLine("Data do empréstimo: " + emprestimosRealizados[i].dataEmprestimo);
                            Console.WriteLine("Data de devolução: " + emprestimosRealizados[i].dataDevolucao);
                        }

                        Console.WriteLine();
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine();

                    }
                }
            }

            public static void VisualizarEmprestimoDoMes(Emprestimo[] emprestimosRealizados)
            {
                Console.Write("Digite o mês: ");
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Empréstimos do mês " + mes + ":");
                Console.ResetColor();
                Console.WriteLine();

                for (int i = 0; i < emprestimosRealizados.Length; i++)
                {
                    if (emprestimosRealizados[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (emprestimosRealizados[i].dataEmprestimo.Month == mes)
                        {
                            Console.WriteLine("Nome do amigo: " + emprestimosRealizados[i].amigo.nome);
                            Console.WriteLine("Nome do responsável: " + emprestimosRealizados[i].amigo.nomeResponsavel);
                            Console.WriteLine("Telefone do amigo: " + emprestimosRealizados[i].amigo.telefone);
                            Console.WriteLine("Endereço do amigo: " + emprestimosRealizados[i].amigo.endereço);
                            Console.WriteLine("Tipo de coleção da revista: " + emprestimosRealizados[i].revista.tipoColecao);
                            Console.WriteLine("Número de edição da revista: " + emprestimosRealizados[i].revista.numeroEdicao);
                            Console.WriteLine("Ano da revista: " + emprestimosRealizados[i].revista.ano);
                            Console.WriteLine("Número da caixa da revista: " + emprestimosRealizados[i].revista.caixa.numero);
                            Console.WriteLine("Data do empréstimo: " + emprestimosRealizados[i].dataEmprestimo);
                            Console.WriteLine("Data de devolução: " + emprestimosRealizados[i].dataDevolucao);
                        }

                        Console.WriteLine();
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine();

                    }
                }
            }

            public static void VisualizarTodosEmprestimos(Emprestimo[] emprestimosRealizados)
            {
                TelaFerramentas.Mensagem("Todos os empréstimos: ", ConsoleColor.Yellow);

                for (int i = 0; i < emprestimosRealizados.Length; i++)
                {
                    if (emprestimosRealizados[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Nome do amigo: " + emprestimosRealizados[i].amigo.nome);
                        Console.WriteLine("Nome do responsável: " + emprestimosRealizados[i].amigo.nomeResponsavel);
                        Console.WriteLine("Telefone do amigo: " + emprestimosRealizados[i].amigo.telefone);
                        Console.WriteLine("Endereço do amigo: " + emprestimosRealizados[i].amigo.endereço);
                        Console.WriteLine("Tipo de coleção da revista: " + emprestimosRealizados[i].revista.tipoColecao);
                        Console.WriteLine("Número de edição da revista: " + emprestimosRealizados[i].revista.numeroEdicao);
                        Console.WriteLine("Ano da revista: " + emprestimosRealizados[i].revista.ano);
                        Console.WriteLine("Número da caixa da revista: " + emprestimosRealizados[i].revista.caixa.numero);
                        Console.WriteLine("Data do empréstimo: " + emprestimosRealizados[i].dataEmprestimo);
                        Console.WriteLine("Data de devolução: " + emprestimosRealizados[i].dataDevolucao);

                        Console.WriteLine();
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine();

                    }
                }
            }

            public static void VisualizarAmigosQueTemMulta(Amigo[] amigosCadastrados)
            {
                TelaFerramentas.Mensagem("Amigos que tem multa: ", ConsoleColor.Yellow);

                for (int i = 0; i < amigosCadastrados.Length; i++)
                {
                    if (amigosCadastrados[i] != null && amigosCadastrados[i].temMulta == true)
                    {
                        Console.WriteLine(amigosCadastrados[i].nome);
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}