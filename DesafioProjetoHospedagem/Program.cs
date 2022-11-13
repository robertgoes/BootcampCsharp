using DesafioProjetoHospedagem.Models;

//Cria os modelos de hóspedes e cadastra na lista de hóspedes
Pessoa pessoa1 = new Pessoa(nome: "Robert");
Pessoa pessoa2 = new Pessoa(nome: "Melany");

List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

//Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

//Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 11);
reserva1.CadastrarSuite(suite);
reserva1.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor total das diárias
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total das diárias: {reserva1.CalcularValorDiaria().ToString("C")}");