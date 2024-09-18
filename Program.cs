using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia1 = new Nokia("47-9999-9999", "XXXX", "0123456", 64);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone1 = new Iphone("47-8888-88888", "YYYYY", "78912345", 64);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("WhatsApp");
