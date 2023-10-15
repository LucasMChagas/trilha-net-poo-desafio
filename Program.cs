using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Iphone iphone = new Iphone("989888888", "14 Pro","000000-00-000000-0", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Nokia");
Nokia nokia = new Nokia("979777777","2660 Flip","111111-11-111111-1",128);
nokia.Ligar();
nokia.InstalarAplicativo("Google tradutor");