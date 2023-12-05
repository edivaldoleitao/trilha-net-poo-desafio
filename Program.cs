using DesafioPOO.Models;

Console.WriteLine("smartphone NOKIA");
Smartphone nokia = new Nokia(numero:"12344",modelo:"modelo2",imei:"13445",memoria:2);
nokia.Ligar();
nokia.InstalarAplicativo("browser");

Console.WriteLine("\n");

Console.WriteLine("smartphone IPHONE");
Smartphone iphone = new Iphone(numero:"15422",modelo:"modelo4",imei:"331",memoria:1);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("google");
