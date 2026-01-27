using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salida = "";
            do {
                Console.WriteLine("¿Quieres salir del bucle?");
                Console.WriteLine("Escribe 1 para salir del bucle");
                salida = Console.ReadLine();

            }while(salida !="1")



        }
    }
}
