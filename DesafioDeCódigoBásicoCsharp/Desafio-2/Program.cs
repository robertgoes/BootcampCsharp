using System;

/*
Desafio
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse 
um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos 
últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que 
indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores 
que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro 
valor
*/

Console.WriteLine("Informe a quantidade de testes: ");
int quantidadeDeTestes = Convert.ToInt32(Console.ReadLine());

for(int contador = 0; contador < quantidadeDeTestes; contador++)
{
    string[] arrayValores = new string[2];

    Console.WriteLine("Informe dois valores, ex: '10243 0243'");
    arrayValores = Console.ReadLine().Split(" ");

    string primeiroValor = arrayValores[0];
    string segundoValor = arrayValores[1];

    if (primeiroValor.Length < 0 && primeiroValor.Length < 1000 && segundoValor.Length < 0 && segundoValor.Length < 1000)
    {
        Console.WriteLine("Não encaixa");
    }
    else if (primeiroValor.EndsWith(segundoValor))
    {
        Console.WriteLine("Encaixa");
    }
    else
    {
        Console.WriteLine("Não encaixa");
    }
}