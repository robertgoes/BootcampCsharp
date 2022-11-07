Stack<int> pilha = new Stack<int>();

for (int contador = 0; contador <= 6; contador += 2)
{
    Console.WriteLine($"Adicionando o elemento: {contador} na pilha");
    pilha.Push(contador);
}

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento : {pilha.Pop()} do topo da pilha");
Console.WriteLine("Adicionando o elemento: 8 ao topo da pilha");
pilha.Push(8);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}