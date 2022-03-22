using System;
namespace Atividade_Clube_Da_Leitura.ConsoleApp
{
    internal partial class Program
    {
        public class GerenciadorDeReserva
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

                GerenciadorDeFerramentas.Mensagem("Revista reservada por 2 dias!", ConsoleColor.Green);

            }

        }
    }
}