using DesafioPOO.Models;

// Implementado Testes com as classes Nokia e Iphone 

Smartphone nokia = new Nokia("999990000", "12355458", "Mod 1", 64);
Console.WriteLine($"Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("999998888", "987654321", "MOd 2", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
