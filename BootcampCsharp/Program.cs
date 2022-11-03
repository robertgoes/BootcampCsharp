using System;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 12;
arrayInteiros[1] = 24;
arrayInteiros[2] = arrayInteiros[1] * 2;

Console.WriteLine($"Quantidade de posições do arrayInteiros: {arrayInteiros.Length}");

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine($"Quantidade de posições do arrayInteiros: {arrayInteiros.Length}");