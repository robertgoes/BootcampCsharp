namespace ConstrutorPorHerança.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}");
        }
    }
}