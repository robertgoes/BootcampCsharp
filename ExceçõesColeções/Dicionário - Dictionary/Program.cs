// Declarando um Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG", "Minas Gerais");
estados.Add("SC", "Santa Catarina");
estados.Add("RJ", "Rio de Janeiro");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Removendo uma chave do Dicionário
Console.WriteLine("Removendo a chave: RJ do dicionário");
estados.Remove("RJ");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Alterando uma chave do Dicionário
Console.WriteLine("Alterando o valor da chave: MG do dicionário");
estados["MG"] = "Minas Gerais, recomendação Belo Horizonte";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}