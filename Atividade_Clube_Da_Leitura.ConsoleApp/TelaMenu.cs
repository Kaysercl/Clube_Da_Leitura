using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class TelaMenu
        {

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

        }
    }
}