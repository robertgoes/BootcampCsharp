using Newtonsoft.Json;
using SerializaçãoJson.Models;

Venda venda1 = new Venda(1, "Marca texto", 3.50M);
Venda venda2 = new Venda(2, "Caderno", 35.00M);

List<Venda> listaVendas = new List<Venda>();

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("../Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);