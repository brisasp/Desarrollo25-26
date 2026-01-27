using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 3");
            int num1 = 5;
            int num2 = 3;
            int resultado = 0;
            int cont = 0; //contador para el bucle
            while (cont < num2)
            {// Aquí el bucle
                resultado += num1;
                cont++;
            }
            
            Console.WriteLine("El resultado " + resultado);
            Console.ReadLine();
        }
    }
}
