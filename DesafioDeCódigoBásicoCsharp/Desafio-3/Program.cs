using System;

/*
Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, 
retorne false.

Entrada
O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do 
desafio.

Saída
A saída consistirá em um tipo booleano: true ou false.
*/

Console.WriteLine("Informe um núemro: ");

int numero = Convert.ToInt32(Console.ReadLine());

int quantidadeDivisores = 0;

for (int contador = 1; contador <= numero; contador++)
{
    if (numero % contador == 0)
    {
        quantidadeDivisores++;
    }

    if (quantidadeDivisores > 3)
    {
        Console.WriteLine(false);
    }
}

Console.WriteLine(quantidadeDivisores == 3);