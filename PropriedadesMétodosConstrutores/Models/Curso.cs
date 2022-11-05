using System;
namespace PropriedadesMétodosConstrutores.Models
{
    public class Curso
    {
        public Curso (){}

        public Curso(string nome)
        {
            Nome = nome;
        }
        
        public string Nome { get; set; }
        public List<Pessoa> Alunos{ get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Nome}");
            }
        }
    }
}