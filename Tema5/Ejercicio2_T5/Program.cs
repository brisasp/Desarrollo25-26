using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine("Selecciona un mes");
            Console.WriteLine("1 - Enero / 2 - Febrero / 3 - Marzo / 4 - Abril / "
             + "5 - Mayo / 6 - Junio / 7 - Julio / 8 - Agosto / 9 - Septiembre /"
             + " 10 - Octubre / 11 - Noviembre / 12 - Diciembre");
            String mes = Console.ReadLine();
            int nummes;
            nummes = Convert.ToInt16(mes);
            if (!(nummes >= 1 && nummes <= 12)) {
                Console.WriteLine("Numero fuera de rango");
                Console.ReadKey();
                return;
            
            }

            switch (mes)
            {
                case "2":
                    Console.WriteLine("28 días");
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    Console.WriteLine("30 días");
                    break;
                default:
                    Console.WriteLine("31 días");
                    break;
            }
            Console.ReadLine();
        }
    }
}
