using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            int n_hospedes = hospedes.Count();
            int capacidade = Suite.Capacidade;
            bool valido = n_hospedes <= capacidade ? true : false;
            if (valido == true)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Não é possível hospedar mais hospedes do que a capacidade suportada!!!");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            return Hospedes.Count();

        }

        public string CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = DiasReservados * Suite.ValorDiaria;


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor = Convert.ToDecimal(Convert.ToDouble(valor) - (Convert.ToDouble(valor) * 0.10));
                return valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"));
            }
            else
            {
                return valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"));

            }

        }
    }
}
