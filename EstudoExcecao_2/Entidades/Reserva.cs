using System;
using EstudoExcecao_2.Entidades.Excecoes;

namespace EstudoExcecao_2.Entidades
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        DateTime now = DateTime.Now;

        public Reserva()
        {
        }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataEntrada < now || dataSaida < now)
            {
                throw new DominioExcecao("data para reservas DESATUALIZADA, data de hoje: " + now);
            }
            else if (dataSaida <= dataEntrada)
            {
                throw new DominioExcecao("data de SAIDA, anterior à de ENTRADA: ");
            }
            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int Duracao()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada);
            return (int)duracao.TotalDays;      //: TotalDay é double, casting para inteiro.
        }
        public void Atualizando(DateTime dataEntrada, DateTime dataSaida)
        {
            if(dataEntrada < now || dataSaida < now)
            {
                throw new DominioExcecao("data para reservas DESATUALIZADA, data de hoje: " + now);
            }
            else if(dataSaida <= dataEntrada)
            {
                throw new DominioExcecao("data de SAIDA, anterior à de ENTRADA: ");
            }
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Quarto: "
                + NumeroQuarto
                + ", Data de entrada: "
                + DataEntrada.ToString("dd/MM/yyyy")
                + ", Data de saída: "
                + DataSaida.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}