using DesafioSmartphone.Models;

Console.WriteLine("Smartphone Nokia:");

Nokia nokia = new Nokia(numero: "9945", modelo: "Nokia 7.0", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Iphone iphone = new Iphone(numero: "9965", modelo: "Iphone 8", imei: "2222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");