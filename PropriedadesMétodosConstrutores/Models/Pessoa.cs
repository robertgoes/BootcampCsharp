using System;
namespace PropriedadesM√©todosConstrutores.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public string Nome {get; set; }

        public int Idade { get; set; }
    }
}