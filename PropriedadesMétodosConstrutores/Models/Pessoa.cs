namespace PropriedadesMétodosConstrutores.Models
{
    public class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                this._nome = value;
            }
        }

        public void Aprensentar()
        {
            Console.WriteLine($"Meu nome é {this.Nome}!");
        }       
    }
}