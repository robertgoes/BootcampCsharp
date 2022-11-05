using System;
using PropriedadesMétodosConstrutores.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Robert";

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Melany";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.Nome = "Inglês";

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);

cursoDeIngles.ListarAlunos();