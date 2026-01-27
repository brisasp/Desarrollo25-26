using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- CONVERSIÓN DE GRADOS -----");
            Console.Write("Introduzca un valor en grados centígrados: ");
            double centigrados = Convert.ToDouble(Console.ReadLine());

            double rankine = (9 * centigrados / 5) + 491.67;
            double kelvin = centigrados + 273.15;

            Console.WriteLine("------------------------------");
            Console.WriteLine("CENTÍGRADOS : {0:0.00}", centigrados);
            //Ella lo hace con esto
            //Console.WriteLine("CENTIGRADOS    :" + centigrados.ToString("0.00")) Para que lo saque unicamente con 2 decimales
            Console.WriteLine("------------------------------");
            Console.WriteLine("RANKINE     : {0:0.00}", rankine);
            Console.WriteLine("KELVIN      : {0:0.00}", kelvin);
        }
    }
}
