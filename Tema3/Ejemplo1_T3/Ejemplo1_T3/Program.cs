using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribimos numeros...");
            Console.WriteLine(120521);

            Console.WriteLine("Escribimos operaciones");
            Console.WriteLine(230 + 520);

            //Linea en blanco
            Console.WriteLine();

            Console.WriteLine("Resultado de la comparacion ; 102>85");
            Console.WriteLine(102>85);

            Console.ReadKey();

            string nombre;
            int edad;
            nombre = "Pepe";
            edad = 32;
            Console.WriteLine("Hola. Me llamo " + nombre + " y tengo " + edad + " años");
            //vector y lector de parametros, le gusta mas esta forma
            Console.WriteLine("Hola. Me llamo {0} y tengo {1} años", nombre,edad);

        }
    }
}
