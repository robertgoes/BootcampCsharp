namespace HerançaPolimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o aluno {Nome}, tenho {Idade} anos, minha nota é {Nota}!");
        }       
    }
}