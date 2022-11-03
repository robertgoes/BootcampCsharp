using System;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 12;
arrayInteiros[1] = 24;
arrayInteiros[2] = arrayInteiros[1] * 2;

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição {contador} - {arrayInteiros[contador]}");
}