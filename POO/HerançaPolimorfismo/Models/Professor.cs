namespace HerançaPolimorfismo.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o professor {Nome}, tenho {Idade} anos, meu salário é {Salario}!");
        }        
    }
}