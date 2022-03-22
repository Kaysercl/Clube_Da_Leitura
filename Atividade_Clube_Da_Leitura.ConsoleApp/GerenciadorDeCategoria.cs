using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeCategoria
        {
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

                GerenciadorDeFerramentas.Mensagem("Categoria cadastrada!", ConsoleColor.Green);
            }

        }
    }
}