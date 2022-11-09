using System;
using Newtonsoft.Json;
using DesserializaçãoJson.Models;

string conteudoArquivo = File.ReadAllText("../Arquivos/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//Serializar a lista de objeto Venda, para exibir no formato JSON

string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

Console.WriteLine(listaSerializada);