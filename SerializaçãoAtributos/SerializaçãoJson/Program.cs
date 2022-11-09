using Newtonsoft.Json;
using SerializaçãoJson.Models;

DateTime dataAtual = DateTime.Now;

Venda venda1 = new Venda(1, "Marca texto", 3.50M, dataAtual);
Venda venda2 = new Venda(2, "Caderno", 35.00M, dataAtual);

List<Venda> listaVendas = new List<Venda>();

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("../Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);