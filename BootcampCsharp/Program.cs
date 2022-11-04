using System;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("SC");
listaString.Add("CE");

Console.WriteLine("Percorrendo a lista com FOR");

for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com FOREACH");

int contadorForeach = 0;

foreach(string item in listaString)
{
    Console.WriteLine($"Posição {contadorForeach} - {item}");
    contadorForeach++;
}