namespace ClasseAbstrata.Models
{
    public class ContaCorrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}