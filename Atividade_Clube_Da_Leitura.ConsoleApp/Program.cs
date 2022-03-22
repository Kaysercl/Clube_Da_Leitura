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
                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();

            } while (opcaoMenuPrincipal != "1" && opcaoMenuPrincipal != "2" && opcaoMenuPrincipal != "3" && opcaoMenuPrincipal != "4"
            && opcaoMenuPrincipal != "5");

            do
            {
                switch (opcaoMenuPrincipal)
                {
                    case "1":

                        do
                        {
                            opcaoMenuCadastro = GerenciadorDeMenu.MenuCadastro();

                        } while (opcaoMenuCadastro != "1" && opcaoMenuCadastro != "2" && opcaoMenuCadastro != "3"
                        && opcaoMenuCadastro != "4" && opcaoMenuCadastro != "5" && opcaoMenuCadastro != "6");

                        switch (opcaoMenuCadastro)
                        {
                            case "1":
                                GerenciadorDeAmigo.CadastrarAmigo(amigosCadastrados, ref indiceAmigo);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                GerenciadorDeRevista.CadastrarRevista(caixasCadastratas, revistasCadastradas, categoriasCadastradas, ref indiceRevista);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "3":
                                GerenciadorDeCaixa.CadastrarCaixa(caixasCadastratas, ref indiceCaixa);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "4":
                                GerenciadorDeEmprestimo.CadastrarEmprestimo(ref reservasCadastradas, ref amigosCadastrados, ref revistasCadastradas, ref emprestimosRealizados, ref indiceEmprestimo);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "5":
                                GerenciadorDeCategoria.CadastrarCategoria(revistasCadastradas, categoriasCadastradas, ref indiceCategoria);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "6":
                                GerenciadorDeReserva.CadastrarReserva(reservasCadastradas, amigosCadastrados, revistasCadastradas, ref indiceReseva);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                GerenciadorDeMenu.MenuCadastro();

                                break;
                        }

                        break;


                    case "2":

                        do
                        {
                            opcaoMenuEditar = GerenciadorDeMenu.MenuEditar();

                        } while (opcaoMenuEditar != "1" && opcaoMenuEditar != "2");

                        switch (opcaoMenuEditar)
                        {
                            case "1":
                                GerenciadorDeAmigo.EditarAmigo(ref amigosCadastrados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                GerenciadorDeRevista.EditarRevista(ref revistasCadastradas, ref caixasCadastratas);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                GerenciadorDeMenu.MenuEditar();

                                break;
                        }

                        break;


                    case "3":

                        do
                        {
                            opcaoMenuExcluir = GerenciadorDeMenu.MenuExcluir();

                        } while (opcaoMenuExcluir != "1" && opcaoMenuExcluir != "2");

                        switch (opcaoMenuExcluir)
                        {
                            case "1":
                                GerenciadorDeAmigo.ExcluirAmigo(ref amigosCadastrados, ref novoAmigosCadastrados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                GerenciadorDeRevista.ExcluirRevista(ref revistasCadastradas, ref novoRevistasCadastradas);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                GerenciadorDeMenu.MenuExcluir();

                                break;
                        }

                        break;


                    case "4":

                        do
                        {
                            opcaoMenuVisualizar = GerenciadorDeMenu.MenuVisualizar();

                        } while (opcaoMenuVisualizar != "1" && opcaoMenuVisualizar != "2" && opcaoMenuVisualizar != "3"
                        && opcaoMenuVisualizar != "4" && opcaoMenuVisualizar != "5" && opcaoMenuVisualizar != "6");

                        switch (opcaoMenuVisualizar)
                        {
                            case "1":
                                TelaVisualizar.VisualizarAmigos(ref amigosCadastrados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "2":
                                TelaVisualizar.VisualizarRevistas(ref revistasCadastradas);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "3":
                                TelaVisualizar.VisualizarTodosEmprestimos(emprestimosRealizados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "4":
                                TelaVisualizar.VisualizarEmprestimoDoMes(emprestimosRealizados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "5":
                                TelaVisualizar.VisualizarEmprestimosEmAberto(emprestimosRealizados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            case "6":
                                TelaVisualizar.VisualizarAmigosQueTemMulta(amigosCadastrados);
                                opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                                Console.Clear();

                                break;

                            default:
                                GerenciadorDeMenu.MenuVisualizar();

                                break;
                        }

                        break;


                    case "5":

                        GerenciadorDeEmprestimo.ExcluirEmprestimo(ref amigosCadastrados, ref emprestimosRealizados, ref novoEmprestimosRealizados);
                        opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                        Console.Clear();

                    break;


                    case "6":

                        GerenciadorDeMulta.ExcluirMulta(amigosCadastrados);
                        opcaoMenuPrincipal = GerenciadorDeMenu.MenuPrincipal();
                        Console.Clear();

                        break;


                    default:

                        Environment.Exit(0);

                        break;

                }

            } while (true);

        }
    }
}