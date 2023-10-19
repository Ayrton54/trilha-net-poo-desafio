using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4987", modelo:"Modelo2", imei:"22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n"+"Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo:"Modelo1", imei:"1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
