using System;
using System.Linq;

namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region variaveis
            Caixa[] caixasCadastratas = new Caixa[100];
            Amigo[] amigosCadastrados = new Amigo[100];
            Amigo[] novoAmigosCadastrados = new Amigo[100];
            Revista[] revistasCadastradas = new Revista[100];
            Categoria[] categoriasCadastradas = new Categoria[100];
            Revista[] novoRevistasCadastradas = new Revista[100];
            Emprestimo[] emprestimosRealizados = new Emprestimo[100];
            Emprestimo[] novoEmprestimosRealizados = new Emprestimo[100]; 
            Reserva[] reservasCadastradas = new Reserva[100];

            string opcaoMenuPrincipal;
            string opcaoMenuCadastro;
            string opcaoMenuEditar;
            string opcaoMenuExcluir;
            string opcaoMenuVisualizar;
            string opcaoMenuFinalizarEmprestimo;
            int indiceAmigo = 0;
            int indiceRevista = 0;
            int indiceCaixa = 0;
            int indiceEmprestimo = 0;
            int indiceCategoria = 0;
            int indiceReseva = 0;
            #endregion

            do
            {
                opcaoMenuPrincipal = MenuPrincipal();

            } while (opcaoMenuPrincipal != "1" && opcaoMenuPrincipal != "2" && opcaoMenuPrincipal != "3" && opcaoMenuPrincipal != "4"
            && opcaoMenuPrincipal != "5");

            do
            {
                switch (opcaoMenuPrincipal)
                {
                    case "1":

                        do
                        {
                            opcaoMenuCadastro = MenuCadastro();

                        } while (opcaoMenuCadastro != "1" && opcaoMenuCadastro != "2" && opcaoMenuCadastro != "3"
                        && opcaoMenuCadastro != "4" && opcaoMenuCadastro != "5" && opcaoMenuCadastro != "6");

                        switch (opcaoMenuCadastro)
                        {
                            case "1":
                                CadastrarAmigo(amigosCadastrados, ref indiceAmigo);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                CadastrarRevista(caixasCadastratas, revistasCadastradas, categoriasCadastradas, ref indiceRevista);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "3":
                                CadastrarCaixa(caixasCadastratas, ref indiceCaixa);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "4":
                                Emprestar(ref reservasCadastradas, ref amigosCadastrados, ref revistasCadastradas, ref emprestimosRealizados, ref indiceEmprestimo);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "5":
                                CadastrarCategoria(revistasCadastradas, categoriasCadastradas, ref indiceCategoria);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "6":
                                CadastrarReserva(reservasCadastradas, amigosCadastrados, revistasCadastradas, ref indiceReseva);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                MenuCadastro();

                                break;
                        }

                        break;


                    case "2":

                        do
                        {
                            opcaoMenuEditar = MenuEditar();

                        } while (opcaoMenuEditar != "1" && opcaoMenuEditar != "2");

                        switch (opcaoMenuEditar)
                        {
                            case "1":
                                EditarAmigo(ref amigosCadastrados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                EditarRevista(ref revistasCadastradas, ref caixasCadastratas);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                MenuEditar();

                                break;
                        }

                        break;


                    case "3":

                        do
                        {
                            opcaoMenuExcluir = MenuExcluir();

                        } while (opcaoMenuExcluir != "1" && opcaoMenuExcluir != "2");

                        switch (opcaoMenuExcluir)
                        {
                            case "1":
                                ExcluirAmigo(ref amigosCadastrados, ref novoAmigosCadastrados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                ExcluirRevista(ref revistasCadastradas, ref novoRevistasCadastradas);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                MenuExcluir();

                                break;
                        }

                        break;


                    case "4":
                        do
                        {
                            opcaoMenuVisualizar = MenuVisualizar();

                        } while (opcaoMenuVisualizar != "1" && opcaoMenuVisualizar != "2" && opcaoMenuVisualizar != "3"
                        && opcaoMenuVisualizar != "4" && opcaoMenuVisualizar != "5" && opcaoMenuVisualizar != "6");

                        switch (opcaoMenuVisualizar)
                        {
                            case "1":
                                VisualizarAmigos(ref amigosCadastrados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                VisualizarRevistas(ref revistasCadastradas);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "3":
                                VisualizarTodosEmprestimos(emprestimosRealizados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "4":
                                VisualizarEmprestimoDoMes(emprestimosRealizados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "5":
                                VisualizarEmprestimosEmAberto(emprestimosRealizados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            case "6":
                                VisualizarAmigosQueTemMulta(amigosCadastrados);
                                opcaoMenuPrincipal = MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                MenuVisualizar();

                                break;
                        }

                        break;


                    case "5":
                        FinalizarEmprestimo(ref amigosCadastrados, ref emprestimosRealizados, ref novoEmprestimosRealizados);
                        opcaoMenuPrincipal = MenuPrincipal();
                        Console.Clear();

                    break;


                    case "6":
                        QuitarMulta(amigosCadastrados);
                        opcaoMenuPrincipal = MenuPrincipal();
                        Console.Clear();

                        break;


                    default:
                        Environment.Exit(0);

                        break;

                }

            } while (true);

        }

        #region metodos

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

            Mensagem("Revista reservada por 2 dias!", ConsoleColor.Green);

        }

        private static void QuitarMulta(Amigo[] amigosCadastrados)
        {
            Console.Write("Digite o nome do amigo que irá quitar a multa: ");
            string nomeQuitarMulta = Console.ReadLine();

            for (int i = 0; i < amigosCadastrados.Length; i++)
            {
                if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == true)
                {
                    Mensagem("Multa quitada!", ConsoleColor.Green);
                    amigosCadastrados[i].temMulta = false;
                    break;

                }
                else if (amigosCadastrados[i] != null && amigosCadastrados[i].nome == nomeQuitarMulta && amigosCadastrados[i].temMulta == false)
                {
                    Mensagem("O amigo não tem multa em aberto!", ConsoleColor.Red);
                    break;
                }
            }
        }

        private static void CadastrarCategoria(Revista[] revistasCadastradas, Categoria[] categoriasCadastradas, ref int indiceCategoria)
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

            Mensagem("Categoria cadastrada!", ConsoleColor.Green);
        }

        public static void VisualizarAmigos(ref Amigo[] amigosCadastrados)
        {
            Mensagem("Amigos cadastrados: ", ConsoleColor.Yellow);

            for (int i = 0; i < amigosCadastrados.Length; i++)
            {
                if (amigosCadastrados[i] != null)
                {
                    Console.WriteLine("Nome do amigo: " + amigosCadastrados[i].nome);
                    Console.WriteLine("Nome do responsável: " + amigosCadastrados[i].nomeResponsavel);
                    Console.WriteLine("Telefone do amigo: " + amigosCadastrados[i].telefone);
                    Console.WriteLine("Endereço do amigo: " + amigosCadastrados[i].endereço);

                }

                Console.WriteLine();
            }
        }

        public static void VisualizarRevistas(ref Revista[] revistasCadastradas)
        {
            Mensagem("Revistas cadastradas: ", ConsoleColor.Yellow);

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

        public static void EditarAmigo (ref Amigo[] amigosCadastrados)
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

            Mensagem("Cadastro do amigo editado!", ConsoleColor.Green);

        }

        public static void EditarRevista (ref Revista[] revistasCadastradas, ref Caixa[] caixasCadastradas)
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

            Mensagem("Cadastro da revista editado!", ConsoleColor.Green);
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

            Mensagem("Amigo excluído do cadastro!", ConsoleColor.Green);
        }

        public static void ExcluirRevista (ref Revista[] revistasCadastradas, ref Revista[] novoRevistasCadastradas)
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

            Mensagem("Revista excluída do cadastro!", ConsoleColor.Green);
        }

        public static void Mensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void FinalizarEmprestimo(ref Amigo[] amigosCadastrados, ref Emprestimo[] emprestimosRealizados, ref Emprestimo[] novoEmprestimosRealizados)
        {
            Console.Write("Digite o nome do amigo que está devolvendo a revista: ");
            string nomeAmigoDevolucao = Console.ReadLine();

            for (int i = 0; i < emprestimosRealizados.Length; i++)
            {
                if (emprestimosRealizados[i] != null && emprestimosRealizados[i].amigo.nome == nomeAmigoDevolucao)
                {

                    if (emprestimosRealizados[i].dataDevolucao < DateTime.Now)
                    {
                        Mensagem("O amigo deve pagar uma multa pelo atraso!", ConsoleColor.Red);
                        
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

            Mensagem("Empréstimo finalizado!", ConsoleColor.Green);
        }

        public static string MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Cadastrar\n2- Editar\n3- Excluir\n4- Visualizar\n5- Finalizar empréstimo\n6- Quitar multa");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.Clear();

            return opcao;
        }

        public static string MenuCadastro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("CADASTROS");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Cadastrar amigo\n2- Cadastrar revista\n3- Cadastrar caixa\n4- Cadastrar empréstimo\n5- Cadastrar categoria\n6- Cadastrar reserva");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        public static string MenuEditar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("EDITAR");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Editar amigo\n2- Editar revista");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        public static string MenuExcluir()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("EXCLUIR");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Excluir amigo\n2- Excluir revista");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        public static string MenuVisualizar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("VISUALIZAR");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Visualizar amigos\n2- Visualizar revistas" +
                "\n3- Visualizar todos os empréstimos\n4- Visualizar empréstimos do mês" +
                "\n5- Visualizar empréstimos em aberto\n6- Visualizar amigos que tem multa em aberto");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        private static void Emprestar(ref Reserva[] reservasCadastradas, ref Amigo[] amigosCadastrados, ref Revista[] revistaCadastrados, ref Emprestimo[] emprestimosRealizados, ref int indiceEmprestimo)
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
            for (int k=0; k < emprestimosRealizados.Length; k++)
            {
                if (emprestimosRealizados[k] != null && emprestimosRealizados[k].amigo.nome == nomeEmprestimo)
                {
                    continuarAmigo = false;
                    Mensagem("Um amigo só pode pegar um livro emprestado por vez!", ConsoleColor.Red);
                }
            }

            //verificacao se o amigo tem multa em aberto
            for (int l = 0; l < amigosCadastrados.Length; l++)
            {
                if (amigosCadastrados[l] != null && amigosCadastrados[l].temMulta == true)
                {
                    Mensagem("O amigo tem multa em aberto e não pode pegar revistas emprestadas até quitar a multa!", ConsoleColor.Red);
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

                for (int j = 0;j < reservasCadastradas.Length; j++)
                {
                    if (reservasCadastradas[j] != null && reservasCadastradas[j].revista.id == idEmprestimo && reservasCadastradas[j].dataTerminoReserva > DateTime.Now)
                    {
                        Mensagem("A revista está reservada no momento!", ConsoleColor.Red);
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
                    Mensagem("Empréstimo cadastrado!", ConsoleColor.Green);

                    break;
                }
            }
        }

        private static void VisualizarEmprestimosEmAberto(Emprestimo[] emprestimosRealizados)
        {
            Mensagem("Empréstimos em aberto: ", ConsoleColor.Yellow);

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

        private static void VisualizarEmprestimoDoMes(Emprestimo[] emprestimosRealizados)
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

        private static void VisualizarTodosEmprestimos(Emprestimo[] emprestimosRealizados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Todos os empréstimos:");
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

        public static void VisualizarAmigosQueTemMulta (Amigo[] amigosCadastrados)
        {
            Mensagem("Amigos que tem multa: ", ConsoleColor.Yellow);

            for (int i = 0; i < amigosCadastrados.Length; i++)
            {
                if (amigosCadastrados[i] != null && amigosCadastrados[i].temMulta == true)
                {
                    Console.WriteLine(amigosCadastrados[i].nome);
                    Console.WriteLine();
                }
            }
        }

        private static void CadastrarCaixa(Caixa[] caixasCadastratas, ref int indiceCaixa)
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

            Mensagem("Caixa cadastrada!", ConsoleColor.Green);
        }

        private static void CadastrarRevista(Caixa[] caixasCadastratas, Revista[] revistaCadastrados, Categoria[] categoriasCadastradas, ref int indiceRevista)
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
                    } else
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

            Mensagem("Revista cadastrada!", ConsoleColor.Green);
        }

        private static void CadastrarAmigo(Amigo[] amigosCadastrados, ref int indiceAmigo)
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

            Mensagem("Amigo cadastrado!", ConsoleColor.Green);
        }
        #endregion
    }
}