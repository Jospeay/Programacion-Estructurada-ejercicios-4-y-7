// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos a la practica3 de validar si un numero es par");

bool esPar(int numero)
{
    return numero % 2 == 0;
}

int numero = 4; // Puedes cambiar este valor para probar con otros números
if (esPar(numero))
{
    Console.WriteLine($"{numero} es un número par.");
}
else
{
    Console.WriteLine($"{numero} es un número impar.");
}
