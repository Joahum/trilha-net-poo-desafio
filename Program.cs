using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia X30 5G", "123456789012345", 128);
Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321098765", 256);

Console.WriteLine($"Nokia - Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}MB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine($"Iphone - Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}MB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

try
{
    var nokiaInvalido = new Nokia("", "Nokia 3310", "123456789012345", 128);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro esperado capturado: {ex.Message}");
}

try
{
    var iphoneInvalido = new Iphone("987654321", "Iphone 12", "", 256);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro esperado capturado: {ex.Message}");
}