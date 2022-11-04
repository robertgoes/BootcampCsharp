using System;
/*
Desafio
Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.

Entrada
A entrada consiste em um número inteiro ( n );

Saída
A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção 
entre o produto e a soma, como no exemplo a baixo:


Produto de dígitos = 2 * 3 * 4 = 24

Soma dos dígitos = 2 + 3 + 4 = 9

Resultado = 24 - 9 = 15
*/

Console.WriteLine("Informe um núemro: ");

int numero = Convert.ToInt32(Console.ReadLine());
int produto = 1, soma = 0;

while(numero > 0)
{
    int digito = numero % 10;

    produto *= digito;
    soma += digito;
    numero /= 10;
}

Console.WriteLine($"Produto dos dígitos = {produto}");

Console.WriteLine($"Soma dos dígitos = {soma}");

Console.WriteLine($"Diferença entre o produto e a soma = {produto - soma}");