using System;
using EstudoExcecao_2.Entidades;
using EstudoExcecao_2.Entidades.Excecoes;

namespace EstudoExcecao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Data de Entrada (dd/MM/aaaa): ");
                DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saida (dd/MM/aaaa): ");
                DateTime dataSaida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(quarto, dataEntrada, dataSaida);
                Console.WriteLine("RESERVA: ");
                Console.WriteLine(reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com as novas datas de Atualização:");
                Console.Write("Data de Entrada (dd/MM/yyyy): ");
                dataEntrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saída (dd/MM/yyyy): ");
                dataSaida = DateTime.Parse(Console.ReadLine());


                reserva.Atualizando(dataEntrada, dataSaida);
                Console.WriteLine("NOVA RESERVA: ");
                Console.WriteLine(reserva);
            }
            catch(DominioExcecao e)
            {
                Console.WriteLine("Erro de ATUALIZAÇÃO de reservas: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro de FORMATO: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro INSPERADO! " + e.Message);
            }
        }
    }
}