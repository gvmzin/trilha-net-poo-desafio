using DesafioPOO.Models;

// Realizado os testes das classes

System.Console.WriteLine("Smartphone Nokia:");

Nokia nokia = new Nokia("1232131231", "Modelo 1", 128, "12321321321");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("ZAP");

System.Console.WriteLine("\nSmartphone Iphone: ");
Iphone iphone = new Iphone("123123", "13", 264, "321321");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

