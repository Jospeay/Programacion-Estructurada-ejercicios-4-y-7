using System;

class vocales
{
    static int ContarVocales(string oracion)
    {
        int contador = 0;
        foreach (char vocal in oracion.ToLower())
        {
            if ("aeiou".Contains(vocal)) contador++;
        }
        return contador;
    }
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine();

        Console.WriteLine($"Cantidad de vocales: {ContarVocales(cadena)}");
    }
}