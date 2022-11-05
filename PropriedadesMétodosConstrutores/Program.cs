using System;
using PropriedadesMétodosConstrutores.Models;

Pessoa pessoa1 = new Pessoa(nome: "Robert", idade: 20);
Pessoa pessoa2 = new Pessoa(nome: "Melany", idade: 1);

Curso cursoDeIngles = new Curso(nome: "Inglês");
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();