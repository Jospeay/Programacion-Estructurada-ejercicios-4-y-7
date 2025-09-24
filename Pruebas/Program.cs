using System;
using System.Linq;

class vocales
{
    static int ContarVocales(string oracion)
    {
        int contador = 0;
        foreach (char vocal in oracion.ToLower())
        {
            if ("aeiouAEIOU".Contains(vocal)) contador++;
        }
        return contador;
    }

    static void Main()
    {
        string cadena = "";

        while (true)
        {
            Console.Write("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cadena)) 
            {
                Console.WriteLine("Entrada inválida.");
            }
            else if (cadena.Any(char.IsDigit))
            {
                Console.WriteLine("Entrada inválida.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Cantidad de vocales: {ContarVocales(cadena)}");
    }
}

