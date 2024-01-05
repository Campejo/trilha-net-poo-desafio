using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("TESTE NOKIA");
Nokia nokia = new Nokia("1234567890", "Tijolão", "871254", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.InformacoesSmartphone();

Console.WriteLine("\n");

Console.WriteLine("TESTE IPHONE");
Iphone iphone = new Iphone("0987654321", "X", "1827464", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InformacoesSmartphone();