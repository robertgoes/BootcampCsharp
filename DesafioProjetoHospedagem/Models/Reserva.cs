using DesafioProjetoHospedagem.Models;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            List<Pessoa> listaHospedes = hospedes;
            
            if (listaHospedes.Count() > Suite.Capacidade)
            {
                Console.WriteLine("Desculpa, mas você atingiu a capacidade máxima da suíte!");    
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal valorDiarias = Suite.ValorDiaria * DiasReservados;
                double desconto = Convert.ToDouble(valorDiarias) * 0.1;
                return valorDiarias - Convert.ToDecimal(desconto);
            }
            else
            {
                return Suite.ValorDiaria * DiasReservados; 
            }
        }
    }
}