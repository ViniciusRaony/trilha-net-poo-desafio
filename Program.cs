using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone:");
Iphone iphone1 = new Iphone(numero: "981402683", modelo: "iPhone 14 PRO", imei: "123456789", memoria: 128 );

iphone1.Ligar();
iphone1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone2 = new Iphone(numero: "981302681", modelo: "iPhone 13", imei: "373456789", memoria: 64 );

iphone1.Ligar();
iphone1.InstalarAplicativo("Clash Of Clans");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia1 = new Nokia(numero: "981552682", modelo: "G21 Plus", imei: "000000000", memoria: 128 );

nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Nubank");