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
            Revista[] revistaCadastrados = new Revista[100];    
            Emprestimo[] emprestimosRealizados = new Emprestimo[100];
            Emprestimo[] novoEmprestimosRealizados = new Emprestimo[100];

            string opcaoMenuPrincipal;
            int indiceAmigo = 0;
            int indiceRevista = 0;
            int indiceCaixa = 0;
            int indiceEmprestimo = 0;
            #endregion

            do
            {
                opcaoMenuPrincipal = MenuPrincipal();

            } while (opcaoMenuPrincipal != "1" && opcaoMenuPrincipal != "2" && opcaoMenuPrincipal != "3" && opcaoMenuPrincipal != "4"
            && opcaoMenuPrincipal != "5" && opcaoMenuPrincipal != "6" && opcaoMenuPrincipal != "7" && opcaoMenuPrincipal != "8");


            do
            {
                switch (opcaoMenuPrincipal)
                {
                    case "1":
                        CadastrarAmigo(amigosCadastrados, ref indiceAmigo);
                        Console.Clear();
                        opcaoMenuPrincipal = MenuPrincipal();

                        break;

                    case "2":
                        CadastrarRevista(caixasCadastratas, revistaCadastrados, ref indiceRevista);
                        Console.Clear();
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "3":
                        CadastrarCaixa(caixasCadastratas, ref indiceCaixa);
                        Console.Clear();
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "4":
                        VisualizarTodosEmprestimos(emprestimosRealizados);
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "5":
                        VisualizarEmprestimoDoMes(emprestimosRealizados);
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "6":
                        VisualizarEmprestimosEmAberto(emprestimosRealizados);
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "7":
                        Emprestar(ref amigosCadastrados, ref revistaCadastrados, ref emprestimosRealizados, ref indiceEmprestimo);
                        //Console.Clear();
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    case "8":
                        FinalizarEmprestimo(ref emprestimosRealizados, ref novoEmprestimosRealizados);
                        Console.Clear();
                        opcaoMenuPrincipal = MenuPrincipal();
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }

            } while (true);

        }

        #region metodos
        public static void FinalizarEmprestimo(ref Emprestimo[] emprestimosRealizados, ref Emprestimo[] novoEmprestimosRealizados)
        {
            Console.Write("Digite o nome do amigo que está devolvendo a revista: ");
            string nomeAmigoDevolucao = Console.ReadLine();

            int j = 0;

            for (int i = 0; i < emprestimosRealizados.Length; i++)
            {
                if (emprestimosRealizados[i] != null && emprestimosRealizados[i].amigo.nome != nomeAmigoDevolucao)
                {
                    novoEmprestimosRealizados[j] = emprestimosRealizados[i];

                    j++;
                    break;
                }
            }

            emprestimosRealizados = novoEmprestimosRealizados;
        }

        public static string MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1- Cadastrar amigo\n2- Cadastrar revista\n3- Cadastrar caixa\n4- Visualizar todos os empréstimos\n" +
                "5- Visualizar empréstimos do mês\n6- Visualizar empréstimos em aberto\n7- Emprestar revista\n8- Finalzar empréstimo\nOu digite qualquer outra tecla para SAIR");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        private static void Emprestar(ref Amigo[] amigosCadastrados, ref Revista[] revistaCadastrados, ref Emprestimo[] emprestimosRealizados, ref int indiceEmprestimo)
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
                    Console.WriteLine();
                    Console.WriteLine("Um amigo só pode pegar um livro emprestado por vez!");
                    Console.WriteLine();
                }
            }

            while (continuarAmigo == true)
            {

                bool existeRevista = false;

                //verificação pelo id se o a revista existe
                while (existeRevista == false)
                {
                    Console.Write("Digite o id da revista que será emprestada: ");
                    string idEmprestimo = Console.ReadLine();

                    for (int j = 0; j < revistaCadastrados.Length; j++)
                    {
                        if (revistaCadastrados[j] != null && idEmprestimo == revistaCadastrados[j].id)
                        {
                            emprestimo.revista = revistaCadastrados[j];
                            existeRevista = true;
                            break;
                        }
                    }
                }

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

                DateTime data02;
                bool eValida02;

                do
                {
                    Console.Write("Digite a data de devolução: ");
                    string dataDaDevolucao = Console.ReadLine();
                    eValida01 = DateTime.TryParse(dataDaDevolucao, out data01);

                    if (eValida01 == true)
                    {
                        emprestimo.dataDevolucao = DateTime.Parse(dataDaDevolucao);
                    }

                } while (eValida01 == false);

                Console.WriteLine();
                emprestimosRealizados[indiceEmprestimo] = emprestimo;
                indiceEmprestimo++;

                break;
            }
        }

        private static void VisualizarEmprestimosEmAberto(Emprestimo[] emprestimosRealizados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Empréstimos em aberto:");
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
        }

        private static void CadastrarRevista(Caixa[] caixasCadastratas, Revista[] revistaCadastrados, ref int indiceRevista)
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

            revistaCadastrados[indiceRevista] = revista;
            indiceRevista++;
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

            amigosCadastrados[indiceAmigo] = amigo;
            indiceAmigo++;
        }
        #endregion
    }
}