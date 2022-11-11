using System;
/*
Desafio
Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o
maior número de vezes no seu array.

Entrada
A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas
nums serão os valores da sua array.

Saída
A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o 
elemento majoritário.
*/
int[] arrayDeNumeros = {7, 8, 7, 8, 9, 7, 9, 6, 5};

int contador = 0;
int maiorContador = 0;
int major = 0;

for (int i = 0; i < arrayDeNumeros.Length; i++)
{
    for (int x = 0; x < arrayDeNumeros.Length; x++)
    {
        if (arrayDeNumeros[i] == arrayDeNumeros[x])
        {
            contador++;
        }
    }

    if (contador > maiorContador)
    {
        maiorContador = contador;
        major = arrayDeNumeros[i];
    }

    contador = 0;
}
            
Console.WriteLine(major);