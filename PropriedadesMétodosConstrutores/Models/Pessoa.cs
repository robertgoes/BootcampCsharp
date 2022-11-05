using System;
namespace PropriedadesMétodosConstrutores.Models
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