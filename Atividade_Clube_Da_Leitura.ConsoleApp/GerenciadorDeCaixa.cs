using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeCaixa
        {
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

                GerenciadorDeFerramentas.Mensagem("Caixa cadastrada!", ConsoleColor.Green);
            }

        }
    }
}