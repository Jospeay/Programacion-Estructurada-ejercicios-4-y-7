// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos a la practica 4 de calcular IVA");

Console.Write("Introduce la cantidad:");
int cantidad = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduce el precio unitario:");
decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
CalcularIVAyTotal(cantidad, precioUnitario);

void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
{
    decimal iva = 0.15m; // 15% de IVA
    decimal precioSinIVA = cantidad * precioUnitario;
    decimal montoIVA = precioSinIVA * iva;
    decimal precioTotal = precioSinIVA + montoIVA;

    Console.WriteLine($"Precio sin IVA: {precioSinIVA:C}");
    Console.WriteLine($"Monto de IVA (15%): {montoIVA:C}");
    Console.WriteLine($"Precio total con IVA: {precioTotal:C}");
}