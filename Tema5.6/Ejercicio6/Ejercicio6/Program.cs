using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("----- CONTROL DE PRECIOS DE VENTA - AUTOMOVIL -----");
                Console.Write("Introduzca el coste real del coche: ");
                double costeReal = Convert.ToDouble(Console.ReadLine());

            //CALCULOS
                double porcentaje = costeReal * 0.25;
                double precioVenta = costeReal + porcentaje;
            //imprimir  resultados por pantalla
                Console.WriteLine("------------------------------");
  
                Console.WriteLine("COSTE REAL : {0:0.00}", costeReal + " Euros");
                Console.WriteLine("PORCENTAJE DE GANANCIA     : {0:0.00}", porcentaje + " Euros");
                Console.WriteLine("PRECIO DE VENTA      : {0:0.00}", precioVenta + " Euros");
            }
        }

}

