using Newtonsoft.Json;
using SerializaçãoJson.Models;

Venda venda1 = new Venda(1, "Marca texto", 3.50M);

string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);

Console.WriteLine(serializado);