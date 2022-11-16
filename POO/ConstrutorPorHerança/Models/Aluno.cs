namespace ConstrutorPorHerança.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }

        private decimal Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o aluno {Nome}, e tenho a nota: {Nota}");
        }

        public void AcrescentarNota(decimal nota)
        {
            Nota = nota;
        }
    }    
}