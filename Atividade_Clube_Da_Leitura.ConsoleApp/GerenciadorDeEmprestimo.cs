using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeEmprestimo
        {
            public static void CadastrarEmprestimo(ref Reserva[] reservasCadastradas, ref Amigo[] amigosCadastrados, ref Revista[] revistaCadastrados, ref Emprestimo[] emprestimosRealizados, ref int indiceEmprestimo)
            {
                Emprestimo emprestimo = new Emprestimo();

                bool existeAmigo = false;
                string nomeEmprestimo = null;

                //verificação pelo nome se o amigo digitado existe
                while (existeAmigo == false)
                {
                    Console.Write("Digite o nome do amigo o qual será emprestado a revista: ");
                    nomeEmprestimo = Console.ReadLine();

                    for (int i = 0; i < amigosCadastrados.Length; i++)
                    {
                        if (amigosCadastrados[i] != null && nomeEmprestimo == amigosCadastrados[i].nome)
                        {
                            emprestimo.amigo = amigosCadastrados[i];
                            existeAmigo = true;
                            break;
                        }
                    }
                }

                bool continuarAmigo = true;

                //verificação se o amigo já tem emprestimo
                for (int k = 0; k < emprestimosRealizados.Length; k++)
                {
                    if (emprestimosRealizados[k] != null && emprestimosRealizados[k].amigo.nome == nomeEmprestimo)
                    {
                        continuarAmigo = false;
                        GerenciadorDeFerramentas.Mensagem("Um amigo só pode pegar um livro emprestado por vez!", ConsoleColor.Red);
                    }
                }

                //verificacao se o amigo tem multa em aberto
                for (int l = 0; l < amigosCadastrados.Length; l++)
                {
                    if (amigosCadastrados[l] != null && amigosCadastrados[l].temMulta == true)
                    {
                        GerenciadorDeFerramentas.Mensagem("O amigo tem multa em aberto e não pode pegar revistas emprestadas até quitar a multa!", ConsoleColor.Red);
                        continuarAmigo = false;
                    }
                }

                while (continuarAmigo == true)
                {

                    int quantidadeDiasPodeEmprestarPelaCategoria = 0;

                    bool existeRevista = false;
                    string idEmprestimo = null;

                    //verificação pelo id se o a revista existe
                    while (existeRevista == false)
                    {
                        Console.Write("Digite o id da revista que será emprestada: ");
                        idEmprestimo = Console.ReadLine();

                        for (int j = 0; j < revistaCadastrados.Length; j++)
                        {
                            if (revistaCadastrados[j] != null && idEmprestimo == revistaCadastrados[j].id)
                            {
                                emprestimo.revista = revistaCadastrados[j];
                                quantidadeDiasPodeEmprestarPelaCategoria = emprestimo.revista.categoria.qntDiasPodeEmprestar;
                                existeRevista = true;
                                break;
                            }
                        }
                    }

                    bool continuarReserva = true;

                    for (int j = 0; j < reservasCadastradas.Length; j++)
                    {
                        if (reservasCadastradas[j] != null && reservasCadastradas[j].revista.id == idEmprestimo && reservasCadastradas[j].dataTerminoReserva > DateTime.Now)
                        {
                            GerenciadorDeFerramentas.Mensagem("A revista está reservada no momento!", ConsoleColor.Red);
                            continuarReserva = false;
                            continuarAmigo = false;
                            break;
                        }
                    }

                    while (continuarReserva == true)
                    {

                        DateTime data01;
                        bool eValida01;

                        do
                        {
                            Console.Write("Digite a data do empréstimo: ");
                            string dataDoEmprestimo = Console.ReadLine();
                            eValida01 = DateTime.TryParse(dataDoEmprestimo, out data01);

                            if (eValida01 == true)
                            {
                                emprestimo.dataEmprestimo = DateTime.Parse(dataDoEmprestimo);
                            }

                        } while (eValida01 == false);

                        emprestimo.dataDevolucao = emprestimo.dataEmprestimo.AddDays(quantidadeDiasPodeEmprestarPelaCategoria);

                        Console.Write("Data de devolução: " + emprestimo.dataDevolucao);

                        emprestimosRealizados[indiceEmprestimo] = emprestimo;
                        indiceEmprestimo++;

                        Console.WriteLine();
                        GerenciadorDeFerramentas.Mensagem("Empréstimo cadastrado!", ConsoleColor.Green);

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
                            GerenciadorDeFerramentas.Mensagem("O amigo deve pagar uma multa pelo atraso!", ConsoleColor.Red);

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

                GerenciadorDeFerramentas.Mensagem("Empréstimo finalizado!", ConsoleColor.Green);
            }

        }
    }
}