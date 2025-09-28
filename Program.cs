// TODO: Realizar os testes com as classes Nokia e Iphone
using poo_desafio.Models;
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

//testes: alterar os valores dos atributos
// nokia.Numero = "111222333";
// Console.WriteLine($"\nNovo número do Nokia: {nokia.Numero}");
// iphone.Numero = "444555666";
// Console.WriteLine($"Novo número do iPhone: {iphone.Numero}");