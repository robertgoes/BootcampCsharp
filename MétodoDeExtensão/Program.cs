using MetodoDeExtensão.Models;

int numero = 5;
bool parOuImpar = numero.EhPar();

Console.WriteLine((parOuImpar? $"o número {numero} é par" : $"o número {numero} é ímpar"));