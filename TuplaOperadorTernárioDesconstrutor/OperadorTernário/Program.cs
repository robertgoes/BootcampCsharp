using System;

Console.WriteLine("Informe um número: ");

int numero = Convert.ToInt32(Console.ReadLine());

bool ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar?"par":"impar"));