using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("9999-999","Tijolinho","imei-nokia",206);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("snake");

Iphone iphone = new Iphone("9999-999","Tijolinho","imei-iphone",1024);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Angry birds");