namespace EstudoAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }

        public bool Ativo { get; set; }
    }
}