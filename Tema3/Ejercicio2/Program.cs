using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.WriteLine("Dime tu nombre...");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad...");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola {0}, tienes {1} años", nombre, edad);


        }
    }
}
