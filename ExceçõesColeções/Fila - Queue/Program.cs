Queue<int> fila = new Queue<int>();

for (int contador = 1; contador <= 4; contador++)
{
    Console.WriteLine($"Adicionando o elemento: {contador} na fila");
    fila.Enqueue(contador);
}

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} da fila");
Console.WriteLine($"Adicionando o elemento: 5 na fila");
fila.Enqueue(5);

foreach (int item in fila)
{
    Console.WriteLine(item);
}