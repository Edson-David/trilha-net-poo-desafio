using System.ComponentModel;
using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Smartphone iPhone = new Iphone(numero: "123", modelo: "7", imei: "1234", memoria: 256 );
Smartphone nokia = new Nokia( numero: "1235", modelo: "9", imei: "4231", memoria: 64);

Console.WriteLine("Smarphone iPhone");
iPhone.Ligar();
iPhone.InstalarAplicativo("Genshin");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");