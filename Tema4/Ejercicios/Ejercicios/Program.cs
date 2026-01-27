using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.Write("Dame un valor: ");
            // Leer el valor desde la consola y convertirlo a número decimal
            valor = int.Parse(Console.ReadLine());

            // Evaluar si es positivo, negativo o cero
            if (valor > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es cero");
            }
        }
    }

}
