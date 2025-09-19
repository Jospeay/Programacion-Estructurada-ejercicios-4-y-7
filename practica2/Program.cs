// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos a practica2 de intercambiar valores");

void intercambiar(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
int a = 5;
int b = 10;
Console.WriteLine($"Antes de intercambiar: a = {a}, b = {b}");
intercambiar(ref a, ref b);
Console.WriteLine($"Después de intercambiar: a = {a}, b = {b}");