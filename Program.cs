using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(novoNumero: "1199999-9999", novoModelo: "Nokia G11 Plus", novoImei: "123456789123456", NovaMemoria: 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(novoNumero: "118888-8888", novoModelo: "Iphone 15 Plus", novoImei: "987654321987654", NovaMemoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Royale");