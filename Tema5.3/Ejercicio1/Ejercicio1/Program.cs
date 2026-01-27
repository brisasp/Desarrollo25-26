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
            string empleado;
            double hTrabajadas;
            double costeHora;
            //Entrada de valores
            Console.WriteLine("--PAGO DE EMPLEADOS--");
            Console.WriteLine("Nombre del empleado");
            empleado = Console.ReadLine();
            Console.WriteLine("Horas trabajadas");
            hTrabajadas= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coste por hora");
            costeHora = Convert.ToDouble(Console.ReadLine());

            //Realizacion de calculos
            double basico = hTrabajadas * costeHora;
            double descuento = basico * 0.12;
            double neto = basico - descuento;

            //Impresion de los resultados por pantalla
            Console.WriteLine("---------------");
            Console.WriteLine("EMPLEADO: " + empleado);
            Console.WriteLine("HORAS TRABAJADAS: " + hTrabajadas.ToString());
            Console.WriteLine("COSTE HORA: " + costeHora.ToString("#, ###.## Euros"));

            //Otra forma de formatear el costeHora
            Console.WriteLine("COSTE HORA : {0:N2} euros", costeHora);
            Console.WriteLine("-------------------------");
            Console.WriteLine("BASICO: " + basico.ToString("#, ###.## Euros"));
            Console.WriteLine("DESCUENTO: " + descuento.ToString("#, ###.## Euros"));
            Console.WriteLine("NETO: " + neto.ToString("#, ###.## Euros"));

        }
    }
}
