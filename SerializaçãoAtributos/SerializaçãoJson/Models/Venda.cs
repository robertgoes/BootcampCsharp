namespace SerializaçãoJson.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }      
    }
}