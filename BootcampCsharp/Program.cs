using System;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 12;
arrayInteiros[1] = 24;
arrayInteiros[2] = arrayInteiros[1] * 2;

Console.WriteLine($"Quantidade de posições do ArrayInteiros: {arrayInteiros.Length}");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"{arrayInteiros[contador]}");
}

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine($"Quantidade de posições do ArrayInteirosDobrado: {arrayInteirosDobrado.Length}");

for(int contador = 0; contador < arrayInteirosDobrado.Length; contador++)
{
    Console.WriteLine($"{arrayInteirosDobrado[contador]}");
}