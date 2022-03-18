using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class TelaCadastro
        {

            public static void CadastrarReserva(Reserva[] reservasCadastradas, Amigo[] amigosCadastrados, Revista[] revistasCadastradas, ref int indiceReserva)
            {
                Reserva reserva = new Reserva();

                bool existeAmigo = false;
                string nomeAmigo = null;

                //verificação pelo nome se o amigo já não está cadastrado
                while (existeAmigo == false)
                {
                    Console.Write("Digite o nome do amigo que reservará a revista: ");
                    nomeAmigo = Console.ReadLine();

                    for (int i = 0; i < amigosCadastrados.Length; i++)
                    {
                        if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeAmigo)
                        {
                            reserva.amigo = amigosCadastrados[i];
                            existeAmigo = true;
                            break;
                        }
                    }
                }

                bool existeRevista = false;
                string idEmprestimo = null;

                //verificação pelo id se a revista existe
                while (existeRevista == false)
                {
                    Console.Write("Digite o id da revista que será reservada: ");
                    idEmprestimo = Console.ReadLine();

                    for (int j = 0; j < revistasCadastradas.Length; j++)
                    {
                        if (revistasCadastradas[j] != null && idEmprestimo == revistasCadastradas[j].id)
                        {
                            revistasCadastradas[j].estaReservada = true;
                            reserva.revista = revistasCadastradas[j];
                            existeRevista = true;
                            break;
                        }
                    }
                }

                reserva.validade = 2;
                reserva.dataTerminoReserva = DateTime.Now.AddDays(reserva.validade);

                reservasCadastradas[indiceReserva] = reserva;
                indiceReserva++;

                TelaFerramentas.Mensagem("Revista reservada por 2 dias!", ConsoleColor.Green);

            }

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

                TelaFerramentas.Mensagem("Amigo cadastrado!", ConsoleColor.Green);
            }

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

                TelaFerramentas.Mensagem("Revista cadastrada!", ConsoleColor.Green);
            }

            public static void CadastrarCaixa(Caixa[] caixasCadastratas, ref int indiceCaixa)
            {
                Caixa caixa = new Caixa();

                Console.Write("Digite a cor da caixa: ");
                string corCaixa = Console.ReadLine();

                bool existeEtiquetaCaixa = true;
                string etiquetaCaixa = null;

                //verificação se a etiqueta já não existe
                while (existeEtiquetaCaixa == true)
                {
                    Console.Write("Digite a etiqueta da caixa: ");
                    etiquetaCaixa = Console.ReadLine();

                    for (int i = 0; i < caixasCadastratas.Length; i++)
                    {
                        if (caixasCadastratas[i] != null && caixasCadastratas[i].etiqueta == etiquetaCaixa)
                        {
                            existeEtiquetaCaixa = true;
                            break;
                        }
                        else
                        {
                            existeEtiquetaCaixa = false;
                            continue;
                        }
                    }
                }

                bool existeNumeroCaixa = true;
                string numeroCaixa = null;

                //verificação se o número da caixa já não existe
                while (existeNumeroCaixa == true)
                {
                    Console.Write("Digite o número da caixa: ");
                    numeroCaixa = Console.ReadLine();

                    for (int i = 0; i < caixasCadastratas.Length; i++)
                    {
                        if (caixasCadastratas[i] != null && caixasCadastratas[i].numero == int.Parse(numeroCaixa))
                        {
                            existeNumeroCaixa = true;
                            break;
                        }
                        else
                        {
                            existeNumeroCaixa = false;
                            continue;
                        }
                    }
                }

                caixa.cor = corCaixa;
                caixa.etiqueta = etiquetaCaixa;
                caixa.numero = int.Parse(numeroCaixa);

                caixasCadastratas[indiceCaixa] = caixa;
                indiceCaixa++;

                TelaFerramentas.Mensagem("Caixa cadastrada!", ConsoleColor.Green);
            }

            public static void CadastrarCategoria(Revista[] revistasCadastradas, Categoria[] categoriasCadastradas, ref int indiceCategoria)
            {
                Categoria categoria = new Categoria();

                Console.Write("Digite o nome da categoria: ");
                string nomeCategoria = Console.ReadLine();

                Console.Write("Digite a quantidade de dias que a revista desta categoria pode ser emprestada: ");
                int qntDiasEmprestada = int.Parse(Console.ReadLine());

                categoria.nome = nomeCategoria;
                categoria.qntDiasPodeEmprestar = qntDiasEmprestada;

                categoriasCadastradas[indiceCategoria] = categoria;

                indiceCategoria++;

                //string continuar;
                //int indiceRevistaCategoria = 0;

                //do
                //{
                //    Console.Write("Digite o id da revista que faz parte desta categoria: ");
                //    string idRevista = Console.ReadLine();

                //    for (int i = 0; i < revistasCadastradas.Length; i++)
                //    {
                //        if (revistasCadastradas[i] != null && revistasCadastradas[i].id == idRevista)
                //        {
                //            categoriasCadastradas[indiceCategoria].revistas[indiceRevistaCategoria] = revistasCadastradas[i];
                //        }
                //    }

                //    Console.Write("Deseja cadastrar outra revista para a categoria? S para SIM e N para NÃO: ");
                //    continuar = Console.ReadLine();

                //    if (continuar == "S")
                //    {
                //        indiceRevistaCategoria++;
                //    }
                //    else if (continuar == "N")
                //    {
                //        indiceRevistaCategoria = 0;
                //    }

                //} while (continuar == "S");

                TelaFerramentas.Mensagem("Categoria cadastrada!", ConsoleColor.Green);
            }

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
                        TelaFerramentas.Mensagem("Um amigo só pode pegar um livro emprestado por vez!", ConsoleColor.Red);
                    }
                }

                //verificacao se o amigo tem multa em aberto
                for (int l = 0; l < amigosCadastrados.Length; l++)
                {
                    if (amigosCadastrados[l] != null && amigosCadastrados[l].temMulta == true)
                    {
                        TelaFerramentas.Mensagem("O amigo tem multa em aberto e não pode pegar revistas emprestadas até quitar a multa!", ConsoleColor.Red);
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
                            TelaFerramentas.Mensagem("A revista está reservada no momento!", ConsoleColor.Red);
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
                        TelaFerramentas.Mensagem("Empréstimo cadastrado!", ConsoleColor.Green);

                        break;
                    }
                }
            }

        }

    }
}