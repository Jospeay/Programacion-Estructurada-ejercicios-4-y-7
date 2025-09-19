using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_programacion
{
    internal class Program
    {
        static void Main()
        {  
            while (true)
            {
                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine(ClasificarEdad(edad));
            }
        }
        static string ClasificarEdad(int edad)
        {
            if (edad <= 0) return "ERROR: edad inválida";
            else if (edad < 18) return "Menor de edad";
            else if (edad >= 18 && edad <= 60) return "Persona adulta";
            else return "Persona adulto mayor";
        }
    }
    }
    

